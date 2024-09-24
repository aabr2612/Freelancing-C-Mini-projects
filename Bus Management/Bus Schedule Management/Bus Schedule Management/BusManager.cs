using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Bus_Schedule_Management
{
    internal class BusManager
    {
        private static readonly string connectionString = "Server=(local);Database=BusesDataManagement;Trusted_Connection=True";
        public static string AddBus(string BusNumber, string Description)
        {
            string message;
            if (!CheckBus(BusNumber))
            {
                string query = "INSERT INTO Buses (BusNumber, Description) VALUES (@BusNumber, @Description)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@BusNumber", BusNumber);
                        command.Parameters.AddWithValue("@Description", Description);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message="Success";
                        }
                        else
                        {
                            message="";
                        }
                    }
                    catch (Exception ex)
                    {
                        message="An error occurred: " + ex.Message;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                message="Bus data exists!";
            }
            return message;
        }
        private static bool CheckBus(string BusNumber)
        {
            string query = "SELECT COUNT(*) FROM Buses WHERE BusNumber=@BusNumber;";
            bool dataExists = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BusNumber", BusNumber);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        dataExists = true;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
            return dataExists;
        }
        public static string AddRoute(string busNumber, int routeNumber, string stationName, string stationDescription)
        {
            if (CheckRoute(busNumber, routeNumber))
            {
                return "Route bus already exists for this station.";
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO BusRoutes (BusNumber, RouteNumber, StationName, StationDescription) " +
                               "VALUES (@BusNumber, @RouteNumber, @StationName, @StationDescription)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BusNumber", busNumber);
                    cmd.Parameters.AddWithValue("@RouteNumber", routeNumber);
                    cmd.Parameters.AddWithValue("@StationName", stationName);
                    cmd.Parameters.AddWithValue("@StationDescription", stationDescription);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        return "Route and station added successfully.";
                    }
                    else
                    {
                        return "Error adding route and station.";
                    }
                }
            }
        }
        private static bool CheckRoute(string busNumber, int routeNumber)
        {
            string query = "SELECT COUNT(*) FROM BusRoutes WHERE BusNumber=@BusNumber AND RouteNumber=@RouteNumber;";
            bool routeExists = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BusNumber", busNumber);
                    command.Parameters.AddWithValue("@RouteNumber", routeNumber);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        routeExists = true;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
            return routeExists;
        }
        public static List<string> GetAllBusNumbers()
        {
            List<string> busNumbers = new List<string>();
            string query = "SELECT BusNumber FROM Buses";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        busNumbers.Add(reader["BusNumber"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while fetching bus numbers: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return busNumbers;
        }

        public static List<string> GetAllStopNumbers(string busNumber)
        {
            List<string> routeNumbers = new List<string>();
            string query = "SELECT RouteNumber FROM BusRoutes where BusNumber=@BusNumber";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BusNumber", busNumber);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        routeNumbers.Add(reader["RouteNumber"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while fetching bus numbers: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return routeNumbers;
        }
        public static string AddTimeTableEntry(string busNumber, int routeNumber, string route1, string route2, string route3, string route4, string route5, string route6, string route7, string route8)
        {
            string resultMessage = string.Empty;
            try
            {
                if (CheckTimeTableEntryExists(busNumber, routeNumber))
                {
                    return "TimeTable entry already exists for the given bus number and route number.";
                }
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    int stationNumber = GetStationNumber(busNumber, routeNumber);
                    string insertTimeTableQuery = @"
                    INSERT INTO TimeTable (stationnumber, Route1, Route2, Route3, Route4, Route5, Route6, Route7, Route8) 
                    VALUES (@stationnumber, @route1, @route2, @route3, @route4, @route5, @route6, @route7, @route8)";
                    SqlCommand insertTimeTableCmd = new SqlCommand(insertTimeTableQuery, conn);
                    insertTimeTableCmd.Parameters.AddWithValue("@stationnumber", stationNumber);
                    insertTimeTableCmd.Parameters.AddWithValue("@route1", route1);
                    insertTimeTableCmd.Parameters.AddWithValue("@route2", route2);
                    insertTimeTableCmd.Parameters.AddWithValue("@route3", route3);
                    insertTimeTableCmd.Parameters.AddWithValue("@route4", route4);
                    insertTimeTableCmd.Parameters.AddWithValue("@route5", route5);
                    insertTimeTableCmd.Parameters.AddWithValue("@route6", route6);
                    insertTimeTableCmd.Parameters.AddWithValue("@route7", route7);
                    insertTimeTableCmd.Parameters.AddWithValue("@route8", route8);
                    insertTimeTableCmd.ExecuteNonQuery();

                    resultMessage = "TimeTable entry added successfully.";
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                resultMessage = "An error occurred: " + ex.Message;
            }
            return resultMessage;
        }
        private static int GetStationNumber(string busNumber, int routeNumber)
        {
            string query = "SELECT busstationnumber FROM BusRoutes WHERE busnumber = @BusNumber AND routenumber = @RouteNumber";
            int stationNumber = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BusNumber", busNumber);
                    command.Parameters.AddWithValue("@RouteNumber", routeNumber);
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        stationNumber = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while checking station number: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return stationNumber;
        }
        private static bool CheckTimeTableEntryExists(string busNumber, int routeNumber)
        {
            string query = "SELECT COUNT(*) FROM TimeTable WHERE stationNumber = (SELECT busstationnumber FROM busroutes WHERE busnumber = @busNumber AND routenumber = @routeNumber)";
            bool entryExists = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@busNumber", busNumber);
                cmd.Parameters.AddWithValue("@routeNumber", routeNumber);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    entryExists = true;
                }
            }

            return entryExists;
        }
        public static string ModifyTimeTableEntry(string busNumber, int routeNumber, string route1, string route2, string route3, string route4, string route5, string route6, string route7, string route8)
        {
            if (!CheckTimeTableEntryExists(busNumber, routeNumber))
            {
                return "TimeTable entry does not exist.";
            }
            string resultMessage = string.Empty;
            try
            {
                int stationNumber = GetStationNumber(busNumber, routeNumber);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string selectQuery = "SELECT COUNT(*) FROM TimeTable WHERE stationnumber = @stationnumber";
                    SqlCommand selectCmd = new SqlCommand(selectQuery, conn);
                    selectCmd.Parameters.AddWithValue("@stationnumber", stationNumber);
                    int existingEntryCount = (int)selectCmd.ExecuteScalar();
                    if (existingEntryCount > 0)
                    {
                        // Update existing entry
                        string updateQuery = @"
                    UPDATE TimeTable 
                    SET Route1 = @route1, Route2 = @route2, Route3 = @route3, 
                        Route4 = @route4, Route5 = @route5, Route6 = @route6, 
                        Route7 = @route7, Route8 = @route8 
                    WHERE stationnumber = @stationnumber";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@route1", route1);
                        updateCmd.Parameters.AddWithValue("@route2", route2);
                        updateCmd.Parameters.AddWithValue("@route3", route3);
                        updateCmd.Parameters.AddWithValue("@route4", route4);
                        updateCmd.Parameters.AddWithValue("@route5", route5);
                        updateCmd.Parameters.AddWithValue("@route6", route6);
                        updateCmd.Parameters.AddWithValue("@route7", route7);
                        updateCmd.Parameters.AddWithValue("@route8", route8);
                        updateCmd.Parameters.AddWithValue("@stationnumber", stationNumber);

                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            resultMessage = "TimeTable entry updated successfully.";
                        }
                        else
                        {
                            resultMessage = "Error updating TimeTable entry.";
                        }
                    }
                    else
                    {
                        resultMessage = "TimeTable entry does not exist.";
                    }
                }
            }
            catch (Exception ex)
            {
                resultMessage = "An error occurred: " + ex.Message;
            }
            return resultMessage;
        }
    }
}