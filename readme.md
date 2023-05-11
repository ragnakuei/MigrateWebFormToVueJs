# Asp.Net WebForm 移轉至 Vue.js

緣由：

1. 因應部份 Asp.Net WebForm 既有的邏輯過於複雜，造成移轉至 Vue.js 過於困難
1. 客戶期望是：翻寫的前後能有所對應 !

解決方式：
> 將 Asp.Net WebForm 指定頁面的所有生命週期都保留，直接在 Vue.js 中如實呈現 !

翻寫後的框架：
> Asp.Net Core Razor Pages + Vue.js

前置知識：

- [Asp.Net WebForm Life Page Cycle](https://learn.microsoft.com/en-us/previous-versions/aspnet/ms178472(v=vs.100)#life-cycle-events)
- JS Promise / async / await 等，非同步處理
- Vue.js
- Asp.Net Core Razor Pages ( 非必要，亦可用 Asp.Net Core MVC )

翻寫頁面

<table>
    <thead>
        <tr>
            <th>WebForm</th>
            <th>Razor Pages</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td rowspan="2"> <a href="AspNetWebForm/Demo.aspx">Demo.aspx</a> </td>
            <td> <a href="AspNetCoreRazorPages/Pages/Demo.cshtml" >Demo.cshtml</a> </td>
        </tr>
        <tr>
            <td> <a href="AspNetCoreRazorPages/Pages/Demo2.cshtml" >Demo2.cshtml</a> </td>
        </tr>
        <tr>
            <td> <a href="AspNetWebForm/DemoEdit.aspx" >DemoEdit.aspx</a> </td>
            <td> <a href="AspNetCoreRazorPages/Pages/DemoEdit.cshtml" >DemoEdit.cshtml</a> </td>
        </tr>
    </tbody>
</table>

注意事項：

- 要拆分頁面邏輯與資料,才不會讓程式碼過於複雜
- WebForm 框架中，如果 Page_Load 或是 Page_Render 事件內有呼叫其他控制項事件，就必須在被呼叫的事件中，額外定義一個 isPostBack 的判斷，以避免陷入無窮迴圈 !
