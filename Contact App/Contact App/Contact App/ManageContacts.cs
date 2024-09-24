using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Contact_App
{
    public partial class ManageContacts : Form
    {
        string ContactNamei;
        public ManageContacts()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        private string EmailCheck(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(email, pattern))
            {
                return "Email is not valid!";
            }
            return "Valid";
        }
        private string PhoneNumberCheck(string phone)
        {
            foreach (char c in phone)
            {
                if (c<'0' || c>'9')
                {
                    return "Invalid phone number!";
                }
            }
            return "Valid";
        }
        private string NameCheck(string contactName)
        {
            foreach (char c in contactName)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return "Contactname must contain only letters and digits.";
                }
            }
            if(contactName==ContactNamei)
            {
                return "Valid";
            }
            return ContactData.ContactNameCheck(contactName);
        }

        private void AddBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ContactInput.Text) || string.IsNullOrEmpty(PhoneInput.Text) || string.IsNullOrEmpty(AddressInput.Text) || string.IsNullOrEmpty(EmailInput.Text))
                {
                    MessageBox.Show("Missing information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string check = NameCheck(ContactInput.Text);
                    if (check=="Valid")
                    {
                        check= EmailCheck(EmailInput.Text);
                        if (check=="Valid")
                        {
                            check=PhoneNumberCheck(PhoneInput.Text);
                            if (check=="Valid")
                            {
                                check=AddressCheck(AddressInput.Text);
                                if (check=="Valid")
                                {
                                    ContactData.AddContact(new Contact(ContactInput.Text, PhoneInput.Text, EmailInput.Text, AddressInput.Text));
                                    MessageBox.Show("Contact added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadData();
                                    ClearInput();
                                    return;
                                }
                            }
                        }
                    }
                    MessageBox.Show(check, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string AddressCheck(string text)
        {
            if (text.Contains(","))
            {
                return "Invalid address, Comma must not be part of address";
            }
            else
            {
                return "Valid";
            }
        }
        private void ClearInput()
        {
            ContactNamei=null;
            ContactInput.Text = null;
            PhoneInput.Text = null;
            AddressInput.Text = null;
            EmailInput.Text = null;
        }
        private void LoadData()
        {
            ArrayList contacts = ContactData.GetContacts();
            ContactViews.DataSource = null;
            ContactViews.Rows.Clear();
            foreach (Contact c in contacts)
            {
                ContactViews.Rows.Add(
                    c.ContactName,
                    c.PhoneNumber,
                    c.Email,
                    c.Address
                    );
            }
        }
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ContactData.LoadContacts();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ContactViews_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (ContactViews.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = ContactViews.SelectedRows[0];
                    if (selectedRow.Index >= 0 && selectedRow.Index < ContactViews.Rows.Count)
                    {
                        ContactNamei=selectedRow.Cells["Column1"].Value?.ToString();
                        ContactInput.Text = selectedRow.Cells["Column1"].Value?.ToString();
                        PhoneInput.Text = selectedRow.Cells["Column2"].Value?.ToString();
                        EmailInput.Text = selectedRow.Cells["Column3"].Value?.ToString();
                        AddressInput.Text = selectedRow.Cells["Column4"].Value?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ContactData.SaveContacts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ContactInput.Text) || string.IsNullOrEmpty(PhoneInput.Text) || string.IsNullOrEmpty(AddressInput.Text) || string.IsNullOrEmpty(EmailInput.Text))
                {
                    MessageBox.Show("Missing information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ContactData.RemoveContact(new Contact(ContactInput.Text, PhoneInput.Text, EmailInput.Text, AddressInput.Text));
                    MessageBox.Show("Contact deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearInput();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ContactInput.Text) || string.IsNullOrEmpty(PhoneInput.Text) || string.IsNullOrEmpty(AddressInput.Text) || string.IsNullOrEmpty(EmailInput.Text))
                {
                    MessageBox.Show("Missing information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string check = NameCheck(ContactInput.Text);
                    if (check=="Valid")
                    {
                        check= EmailCheck(EmailInput.Text);
                        if (check=="Valid")
                        {
                            check=PhoneNumberCheck(PhoneInput.Text);
                            if (check=="Valid")
                            {
                                check=AddressCheck(AddressInput.Text);
                                if (check=="Valid")
                                {
                                    ContactData.EditContact(ContactNamei,new Contact(ContactInput.Text, PhoneInput.Text, EmailInput.Text, AddressInput.Text));
                                    MessageBox.Show("Contact updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadData();
                                    ClearInput();
                                    return;
                                }
                            }
                        }
                    }
                    MessageBox.Show(check, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
