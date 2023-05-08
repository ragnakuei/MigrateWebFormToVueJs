using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetWebForm
{
    public partial class _Demo : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 假設資料透過 ado.net 取出
            var books = GetBooks();
            gv.DataSource = books;
            gv.DataBind();
        }

        protected void OnPreRender(object sender, EventArgs e)
        {
            Console.WriteLine("OnPreRender");
        }

        protected void gv_OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                var bookIdStr = DataBinder.Eval(e.Row.DataItem, "Id").ToString();
                // var bookId    = Guid.Parse(bookIdStr);

                var lb_price = e.Row.FindControl("lb_price") as Label;
                if (lb_price != null)
                {
                    // 設定控制項屬性
                    var priceStr = DataBinder.Eval(e.Row.DataItem, "Price").ToString();
                    var price    = decimal.Parse(priceStr);
                    lb_price.Text = price.ToString("0.0");
                }

                var lb_publish_date = e.Row.FindControl("lb_publish_date") as Label;
                if (lb_publish_date != null)
                {
                    // 設定控制項屬性
                    var publishDateStr = DataBinder.Eval(e.Row.DataItem, "PublishDate").ToString();
                    var publishDate    = DateTime.Parse(publishDateStr);
                    lb_publish_date.Text = publishDate.ToString("yyyy/MM/dd");
                }

                // 取得控制項
                var btn_edit = e.Row.FindControl("btn_edit") as Button;
                if (btn_edit != null)
                {
                    // 設定控制項屬性
                    var editableStr = DataBinder.Eval(e.Row.DataItem, "Editable").ToString();
                    var editable    = bool.Parse(editableStr);
                    btn_edit.Visible         =  editable;
                    btn_edit.CommandArgument =  bookIdStr;
                }

                var btn_delete = e.Row.FindControl("btn_delete") as Button;
                if (btn_delete != null)
                {
                    // 設定控制項屬性
                    var deletableStr = DataBinder.Eval(e.Row.DataItem, "Deletable").ToString();
                    var deletable    = bool.Parse(deletableStr);
                    btn_delete.Visible         =  deletable;
                    btn_delete.CommandArgument =  bookIdStr;
                }
            }
        }

        protected void btn_edit_Click(object sender, EventArgs e)
        {
            var btn_edit = (sender as Button);
            var bookId   = Guid.Parse(btn_edit?.CommandArgument);
            Console.WriteLine(bookId);
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            var btn_delete = (sender as Button);
            var bookId     = Guid.Parse(btn_delete?.CommandArgument);
            Console.WriteLine(bookId);
        }

        private DataTable GetBooks()
        {
            var books = new DataTable();
            books.Columns.Add("Id",          typeof(Guid));
            books.Columns.Add("Title",       typeof(string));
            books.Columns.Add("Author",      typeof(string));
            books.Columns.Add("Genre",       typeof(string));
            books.Columns.Add("Price",       typeof(decimal));
            books.Columns.Add("PublishDate", typeof(DateTime));
            books.Columns.Add("Editable",    typeof(bool));
            books.Columns.Add("Deletable",   typeof(bool));

            // 產生 10 筆資料
            for (int i = 0; i < 10; i++)
            {
                var row = books.NewRow();
                row["Id"]          = Guid.NewGuid();
                row["Title"]       = $"Title {i}";
                row["Author"]      = $"Author {i}";
                row["Genre"]       = $"Genre {i}";
                row["Price"]       = i * 10;
                row["PublishDate"] = DateTime.Now.AddDays(i);
                row["Editable"]    = i % 2 == 0;
                row["Deletable"]   = i % 3 == 0;
                books.Rows.Add(row);
            }

            return books;
        }
    }
}
