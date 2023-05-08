# Asp.Net WebForm 移轉至 Vue.js

緣由：

> 1. 因應部份 Asp.Net WebForm 既有的邏輯過於複雜，造成移轉至 Vue.js 過於困難
> 1. 再加上客戶期望是：翻寫的前後能有所對應 !

解決方式：
> 將 Asp.Net WebForm 指定頁面的所有生命週期都保留，直接在 Vue.js 中如實呈現 !

翻寫後的框架：
> Asp.Net Core Razor Pages + Vue.js
 
前置知識：
> - [Asp.Net WebForm Life Page Cycle](https://learn.microsoft.com/en-us/previous-versions/aspnet/ms178472(v=vs.100)#life-cycle-events)
> - JS Promise / async / await 等，非同步處理
> - Vue.js
> - Asp.Net Core Razor Pages ( 非必要，亦可用 Asp.Net Core MVC )

翻寫頁面
> - Asp.Net WebForm
>   - [Demo.aspx](AspNetWebForm/Demo.aspx)
> - Asp.Net Core Razor Pages
>   - [Demo.cshtml](AspNetCoreRazorPages/Pages/Demo) - 資料隨著頁面載入時取得
>   - [Demo2.cshtml](AspNetCoreRazorPages/Pages/Demo2) - 資料透過 ajax 取得
  
注意事項：
> - 要拆分頁面邏輯與資料,才不會讓程式碼過於複雜
