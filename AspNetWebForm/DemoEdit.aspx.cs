using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using AspNetWebForm.Models;

namespace AspNetWebForm
{
    public partial class _DemoEdit : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddl_1.Items.Clear();
                ddl_1.Items.Add(new ListItem("",  ""));
                ddl_1.Items.Add(new ListItem("Y", "Y"));
                ddl_1.Items.Add(new ListItem("N", "N"));
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Console.WriteLine("OnPreRender");

            if(!IsPostBack)
            {
                rb_option_OnCheckedChanged(null, null);
            }
        }

        protected void rb_option_OnCheckedChanged(object sender, EventArgs e)
        {
            if (rb_option_A.Checked)
            {
                div_1.Visible        = true;
                div_status.Visible   = true;
                div_status_1.Visible = true;
                div_status_0.Visible = true;
                div_status_2.Visible = false;
                return;
            }

            if (rb_option_B.Checked)
            {
                div_1.Visible        = false;
                div_status.Visible   = true;
                div_status_1.Visible = false;
                div_status_0.Visible = false;
                div_status_2.Visible = true;
                return;
            }

            div_1.Visible        = false;
            div_status.Visible   = false;
            div_status_1.Visible = false;
            div_status_0.Visible = false;
            div_status_2.Visible = false;

            rb_status_OnCheckedChanged(null, null);
        }

        protected void rb_status_OnCheckedChanged(object sender, EventArgs e)
        {
            if (rb_status_0.Checked || rb_status_1.Checked)
            {
                div_2.Visible = true;
            }
            else if (rb_status_2.Checked)
            {
                div_2.Visible = false;
            }

            ddl_1.ClearSelection();
            ddl_1_OnSelectedIndexChanged(null, null);
        }

        protected void ddl_1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            div_ddl_2.Visible = false;
            ddl_2.Items.Clear();

            if (rb_status_0.Checked)
            {
                if (ddl_1.SelectedValue == "Y")
                {
                    ddl_2.Items.Add(new ListItem("N", "N"));
                    div_ddl_2.Visible = true;
                }

                if (ddl_1.SelectedValue == "N")
                {
                    ddl_2.Items.Add(new ListItem("Y", "Y"));
                    div_ddl_2.Visible = true;
                }
            }
            else if (rb_status_1.Checked)
            {
                if (ddl_1.SelectedValue == "Y")
                {
                    ddl_2.Items.Add(new ListItem("Y", "Y"));
                    div_ddl_2.Visible = true;
                }

                if (ddl_1.SelectedValue == "N")
                {
                    ddl_2.Items.Add(new ListItem("N", "N"));
                    div_ddl_2.Visible = true;
                }
            }

            ddl_2_OnSelectedIndexChanged(null, null);
        }

        protected void ddl_2_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_2.SelectedValue == "Y")
            {
                div_publish_date.Visible = true;
            }
            else if (ddl_2.SelectedValue == "N")
            {
                div_publish_date.Visible = false;
            }
        }

        protected void btn_submit_OnClick(object sender, EventArgs e)
        {
            var resultDto = new ResultDto();
            resultDto.Option = GetOption();
            resultDto.Status = GetStatus();

            if (rb_status_0.Checked)
            {
                resultDto.status_0_date = status_0_date.Text;
            }

            if (rb_status_2.Checked)
            {
                resultDto.status_2_date = status_2_date.Text;
            }

            resultDto.Comment = comment.Text;
            resultDto.ddl_1   = ddl_1.SelectedValue;
            resultDto.ddl_2   = ddl_2.SelectedValue;

            if (ddl_2.SelectedValue == "Y")
            {
                resultDto.publish_date = publish_date.Text;
            }

            // Save Process
        }

        private string GetOption()
        {
            if (rb_option_A.Checked)
                return "A";

            if (rb_option_B.Checked)
                return "B";

            return string.Empty;
        }

        private string GetStatus()
        {
            if (rb_status_0.Checked)
                return "0";

            if (rb_status_1.Checked)
                return "1";

            if (rb_status_2.Checked)
                return "2";

            return string.Empty;
        }
    }
}
