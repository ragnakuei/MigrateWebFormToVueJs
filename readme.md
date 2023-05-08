# Asp.Net WebForm 移轉至 Vue.js

因應部份 Asp.Net WebForm 既有的邏輯過於複雜，造成移轉至 Vue.js 過於困難

再加上客戶期望是：翻寫的前後能有所對應 !

想到的方式就是將 Asp.Net WebForm 指定頁面的所有生命週期都保留，直接在 Vue.js 中如實呈現 !

翻寫後的框架：
- Asp.Net Core Razor Pages + Vue.js
 
前置知識：
- [Asp.Net WebForm Life Page Cycle](https://learn.microsoft.com/en-us/previous-versions/aspnet/ms178472(v=vs.100)#life-cycle-events)
- JS Promise / async / await 等，非同步處理
- Vue.js
- Asp.Net Core Razor Pages ( 非必要，亦可用 Asp.Net Core MVC )


翻寫頁面
- Asp.Net WebForm
  - [Demo.aspx](https://localhost:44312/Demo.aspx)
- Asp.Net Core Razor Pages
  - [Demo.cshtml]()
  
