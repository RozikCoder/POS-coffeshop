using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_CoffeShop.Moduls
{
    public class StaffModule
    {
        private List<Staff> staffList;

        public StaffModule()
        {
            staffList = new List<Staff>();
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            staffList.Add(new Staff
            {
                StaffID = "S001",
                FullName = "John Manager",
                Username = "john.m",
                Role = "Manager",
                Email = "john@coffee.com",
                Phone = "012-345-6789",
                Status = "Active",
                LastLogin = DateTime.Now.AddHours(-2).ToString("yyyy-MM-dd HH:mm")
            });

            staffList.Add(new Staff
            {
                StaffID = "S002",
                FullName = "Sarah Cashier",
                Username = "sarah.c",
                Role = "Cashier",
                Email = "sarah@coffee.com",
                Phone = "012-345-6790",
                Status = "Active",
                LastLogin = DateTime.Now.AddHours(-5).ToString("yyyy-MM-dd HH:mm")
            });

            staffList.Add(new Staff
            {
                StaffID = "S003",
                FullName = "Mike Barista",
                Username = "mike.b",
                Role = "Cashier",
                Email = "mike@coffee.com",
                Phone = "012-345-6791",
                Status = "Active",
                LastLogin = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd HH:mm")
            });

            staffList.Add(new Staff
            {
                StaffID = "S004",
                FullName = "Emma Staff",
                Username = "emma.s",
                Role = "Cashier",
                Email = "emma@coffee.com",
                Phone = "012-345-6792",
                Status = "Inactive",
                LastLogin = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd HH:mm")
            });
        }

        public List<Staff> GetAllStaff()
        {
            return staffList.ToList();
        }

        public Staff GetStaffById(string staffId)
        {
            return staffList.FirstOrDefault(s => s.StaffID == staffId);
        }

        public Staff GetStaffByUsername(string username)
        {
            return staffList.FirstOrDefault(s => s.Username == username);
        }

        public void AddStaff(Staff staff)
        {
            // Generate new Staff ID
            int maxId = 0;
            foreach (var s in staffList)
            {
                if (s.StaffID.StartsWith("S"))
                {
                    int id = int.Parse(s.StaffID.Substring(1));
                    if (id > maxId) maxId = id;
                }
            }
            staff.StaffID = "S" + (maxId + 1).ToString("D3");
            staffList.Add(staff);
        }

        public void UpdateStaff(Staff updatedStaff)
        {
            var staff = staffList.FirstOrDefault(s => s.StaffID == updatedStaff.StaffID);
            if (staff != null)
            {
                staff.FullName = updatedStaff.FullName;
                staff.Username = updatedStaff.Username;
                staff.Role = updatedStaff.Role;
                staff.Email = updatedStaff.Email;
                staff.Phone = updatedStaff.Phone;
                staff.Status = updatedStaff.Status;
            }
        }

        public void DeleteStaff(string staffId)
        {
            var staff = staffList.FirstOrDefault(s => s.StaffID == staffId);
            if (staff != null)
            {
                staffList.Remove(staff);
            }
        }

        public void UpdateLastLogin(string staffId)
        {
            var staff = staffList.FirstOrDefault(s => s.StaffID == staffId);
            if (staff != null)
            {
                staff.LastLogin = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            }
        }

        public List<Staff> GetActiveStaff()
        {
            return staffList.Where(s => s.Status == "Active").ToList();
        }

        public List<Staff> GetStaffByRole(string role)
        {
            return staffList.Where(s => s.Role == role).ToList();
        }

        public List<Staff> SearchStaff(string searchText)
        {
            searchText = searchText.ToLower();
            return staffList.Where(s =>
                s.StaffID.ToLower().Contains(searchText) ||
                s.FullName.ToLower().Contains(searchText) ||
                s.Username.ToLower().Contains(searchText) ||
                s.Email.ToLower().Contains(searchText) ||
                s.Phone.Contains(searchText)
            ).ToList();
        }

        public int GetTotalStaffCount()
        {
            return staffList.Count;
        }

        public int GetActiveStaffCount()
        {
            return staffList.Count(s => s.Status == "Active");
        }

        public int GetManagerCount()
        {
            return staffList.Count(s => s.Role == "Manager");
        }

        public int GetCashierCount()
        {
            return staffList.Count(s => s.Role == "Cashier");
        }
    }

    public class Staff
    {
        public string StaffID { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        public string LastLogin { get; set; }
        public DateTime CreatedDate { get; set; }

        public Staff()
        {
            CreatedDate = DateTime.Now;
            Status = "Active";
        }

        public bool IsActive()
        {
            return Status == "Active";
        }

        public bool IsManager()
        {
            return Role == "Manager";
        }

        public bool IsCashier()
        {
            return Role == "Cashier";
        }
    }
}
