using System;
using System.Collections;
using System.IO;

namespace Contact_App
{
    public class ContactData
    {
        private static ArrayList contactList = new ArrayList();
        private static string filePath = "contact.txt";
        public static void AddContact(Contact contact)
        {
            try
            {
                contactList.Add(contact);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while adding a contact.", ex);
            }
        }
        public static string RemoveContact(Contact contact)
        {
            try
            {
                foreach (Contact cont in contactList)
                {
                    if (contact.ContactName == cont.ContactName)
                    {
                        contactList.Remove(cont);
                        return "Contact removed successfully!";
                    }
                }
                return "Contact not found";
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while removing a contact.", ex);
            }
        }
       public static void EditContact(string oldContactName,Contact updatedContact)
       {
                try
                {
                    Contact contactToEdit = null;

                    foreach (Contact contact in contactList)
                    {
                        if (contact.ContactName == oldContactName)
                        {
                            contactToEdit = contact;
                            break;
                        }
                    }
                    if (contactToEdit != null)
                    {
                        contactToEdit.ContactName = updatedContact.ContactName;
                        contactToEdit.PhoneNumber = updatedContact.PhoneNumber;
                        contactToEdit.Email = updatedContact.Email;
                        contactToEdit.Address = updatedContact.Address;
                    }
                    else
                    {
                        throw new ApplicationException("Contact not found.");
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("An error occurred while editing a contact.", ex);
                }
            }
        public static void LoadContacts()
        {
            try
            {
                contactList.Clear();
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(',');
                        if (parts.Length == 4)
                        {
                            Contact contact = new Contact(parts[0], parts[1], parts[2], parts[3]);
                            contactList.Add(contact);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                throw new ApplicationException("The specified file was not found.");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while loading the contacts.", ex);
            }
        }
        public static void SaveContacts()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Contact contact in contactList)
                    {
                        writer.WriteLine($"{contact.ContactName},{contact.PhoneNumber},{contact.Email},{contact.Address}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while saving the contacts.", ex);
            }
        }
        public static ArrayList GetContacts()
        {
            return contactList;
        }
        public static string ContactNameCheck(string contactName)
        {
            foreach (Contact c in contactList)
            {
                if (c.ContactName==contactName)
                {
                    return "Invalid";
                }
            }
            return "Valid";
        }
    }
}
