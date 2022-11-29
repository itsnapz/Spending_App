# 💲 Spending App 💲

[![forthebadge](https://forthebadge.com/images/badges/made-with-c-sharp.svg)](https://forthebadge.com)
[![forthebadge](https://forthebadge.com/images/badges/it-works-why.svg)](https://forthebadge.com)
[![forthebadge](https://forthebadge.com/images/badges/0-percent-optimized.svg)](https://forthebadge.com)



## 💻 Screenshot základního UI aplikace 💻

 ![image](https://i.imgur.com/YApGYz7.png)

  > #### Pro přidání nového uživatele vyplníme v základním UI aplikace jméno, příjmení a email uživatele a stiskneme tlačítko Add.


### UpdateUI metoda pro Form1
```
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
