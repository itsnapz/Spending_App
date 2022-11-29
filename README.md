# 💲 Spending App 💲

[![forthebadge](https://forthebadge.com/images/badges/made-with-c-sharp.svg)](https://forthebadge.com)
[![forthebadge](https://forthebadge.com/images/badges/it-works-why.svg)](https://forthebadge.com)
[![forthebadge](https://forthebadge.com/images/badges/0-percent-optimized.svg)](https://forthebadge.com)



## 💻 Základní UI aplikace 💻

 ![image](https://i.imgur.com/YApGYz7.png)

  > - #### Pro **přidání** nového uživatele vyplníme v základním UI aplikace **jméno**, **příjmení** a **email** uživatele a stiskneme tlačítko       **Add**.
  > - #### Pro **otevření účtu** již vytvořené osoby stačí **kliknout** na jméno v UI aplikace 🖱 **levým tlačítkem myši** 🖱.



## 🖋 UpdateUI metoda pro Form1 🖋
```c#
    private void UpdateUi()
            {
                _pnlUsers.Controls.Clear();
                int i = 0;
                foreach (var user in _users)
                {
                    UsersControl control = new(user);
                    control.Location = new Point(0, (control.Height * i) + 5);
                    control.OnItemClick += Control_OnItemClick;
                    _pnlUsers.Controls.Add(control);
                    i++;
                }
            }
```
 > - #### **_pnlUsers** představuje **Panel** ve WinForms

## 🧑 Přidání nového uživatele ve Form1 🧑
```c#
    private void _btnAdd_Click(object sender, EventArgs e)
            {
                _database.Users.Add(new User()
                {
                    Name=_txtName.Text,
                    Email=_txtEmail.Text,
                    Surname=_txtSurname.Text,
                });
                _database.SaveChanges();
            }
```

## ✅ Označení objednávky za vyřízenou ve SpendControl.cs ✅
```c#
    private void _checkIsPaid_CheckedChanged(object sender, EventArgs e)
        {
            _checkIsPaid.Enabled = false;
            _spend.Paid = true;
            _lblDate.Text = DateTime.Now.ToShortDateString();
            _database.SaveChanges();
        }
```
