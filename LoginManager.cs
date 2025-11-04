using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class LoginManager
{
    // Dictionary lưu trữ tài khoản mặc định
    private Dictionary<string, string> defaultAccounts;

    public LoginManager()
    {
        InitializeDefaultAccounts();
    }

    // Khởi tạo tài khoản mặc định
    private void InitializeDefaultAccounts()
    {
        defaultAccounts = new Dictionary<string, string>
        {
            { "admin", "123456" },     // Tài khoản admin
            { "user", "password" },    // Tài khoản user
            { "guest", "guest123" }    // Tài khoản guest
        };
    }

    // Phương thức đăng nhập
    public bool Login(string username, string password)
    {
        // Kiểm tra đầu vào
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        // Kiểm tra tài khoản
        if (defaultAccounts.ContainsKey(username))
        {
            if (defaultAccounts[username] == password)
            {
                MessageBox.Show($"Đăng nhập thành công!\nChào mừng {username}!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Sai mật khẩu!", "Lỗi đăng nhập",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        else
        {
            MessageBox.Show("Tài khoản không tồn tại!", "Lỗi đăng nhập",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    // Thêm tài khoản mới (nếu cần)
    public void AddAccount(string username, string password)
    {
        if (!defaultAccounts.ContainsKey(username))
        {
            defaultAccounts.Add(username, password);
            MessageBox.Show($"Đã thêm tài khoản {username}!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    // Lấy danh sách tài khoản (cho mục đích debug)
    public string GetAccountList()
    {
        string result = "Danh sách tài khoản:\n";
        foreach (var account in defaultAccounts)
        {
            result += $"Username: {account.Key} - Password: {account.Value}\n";
        }
        return result;
    }
}