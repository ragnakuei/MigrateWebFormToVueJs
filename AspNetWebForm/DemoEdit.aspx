<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master"
EnableEventValidation="false"
AutoEventWireup="true" CodeBehind="DemoEdit.aspx.cs" Inherits="AspNetWebForm._DemoEdit" %>

<asp:Content ContentPlaceHolderID="MainContent"
             ID="BodyContent"
             runat="server" >

	<div class="form-horizontal row-border" >

		<div class="form-group row" >
			<asp:Label AssociatedControlID="rb_option_A"
			           CssClass="col-md-2 control-label"
			           runat="server" >
				Option
			</asp:Label>
			<div class="col-md-10" >
				<asp:RadioButton AutoPostBack="True"
				                 CssClass="radio-inline"
				                 GroupName="Option"
				                 ID="rb_option_A"
				                 OnCheckedChanged="rb_option_OnCheckedChanged"
				                 runat="server"
				                 Text="A" />
				<asp:RadioButton AutoPostBack="True"
				                 CssClass="radio-inline"
				                 GroupName="Option"
				                 ID="rb_option_B"
				                 OnCheckedChanged="rb_option_OnCheckedChanged"
				                 runat="server"
				                 Text="B" />
			</div>
		</div>
		<div class="form-group row"
		     id="div_status"
		     runat="server" >
			<asp:Label AssociatedControlID="rb_status_1"
			           CssClass="col-md-2 control-label"
			           runat="server" >
				Status
			</asp:Label>
			<div class="col-md-10" >
				<div id="div_status_1"
				     runat="server" >
					<asp:RadioButton AutoPostBack="True"
					                 GroupName="Status"
					                 ID="rb_status_1"
					                 OnCheckedChanged="rb_status_OnCheckedChanged"
					                 runat="server"
					                 Text="可用" />
				</div>
				<div class="form-inline"
				     id="div_status_0"
				     runat="server"
				     style="margin: 5px 0 5px 0" >
					<asp:RadioButton AutoPostBack="True"
					                 GroupName="Status"
					                 ID="rb_status_0"
					                 OnCheckedChanged="rb_status_OnCheckedChanged"
					                 runat="server"
					                 Text="不可用" />
					<asp:TextBox CssClass="form-control"
					             ID="status_0_date"
					             runat="server"
					             TextMode="Date" >
					</asp:TextBox>
				</div>
				<div class="form-inline"
				     id="div_status_2"
				     runat="server" >
					<asp:RadioButton AutoPostBack="True"
					                 GroupName="Status"
					                 ID="rb_status_2"
					                 OnCheckedChanged="rb_status_OnCheckedChanged"
					                 runat="server"
					                 Text="其他" />
					<asp:TextBox CssClass="form-control"
					             ID="status_2_date"
					             runat="server"
					             TextMode="Date" >
					</asp:TextBox>
				</div>
			</div>
		</div>
		<div id="div_1"
		     runat="server" >
			<div class="form-group row" >
				<asp:Label AssociatedControlID="comment"
				           CssClass="col-md-2 control-label"
				           runat="server" >
					Comment
				</asp:Label>
				<div class="col-md-10" >
					<asp:TextBox CssClass="form-control"
					             ID="comment"
					             runat="server"
					             TextMode="MultiLine" >
					</asp:TextBox>
				</div>
			</div>

			<div class="form-group row"
			     id="div_2"
			     runat="server" >
				<asp:Label AssociatedControlID="ddl_1"
				           CssClass="col-md-2 control-label"
				           runat="server" >
					ddl_1
				</asp:Label>
				<div class="col-md-10" >
					<asp:DropDownList AutoPostBack="True"
					                  CssClass="form-control"
					                  ID="ddl_1"
					                  OnSelectedIndexChanged="ddl_1_OnSelectedIndexChanged"
					                  runat="server" />
				</div>
			</div>

			<div id="div_ddl_2"
			     runat="server" >

				<div class="form-group row" >
					<asp:Label AssociatedControlID="ddl_2"
					           CssClass="col-md-2 control-label"
					           runat="server" >
						ddl_2
					</asp:Label>
					<div class="col-md-10" >
						<asp:DropDownList CssClass="form-control"
						                  ID="ddl_2"
						                  OnSelectedIndexChanged="ddl_2_OnSelectedIndexChanged"
						                  runat="server" />
					</div>
				</div>
				<div class="form-group row" id="div_publish_date" runat="server" >
					<asp:Label AssociatedControlID="publish_date"
					           CssClass="col-md-2 control-label"
					           runat="server" >
						Publish Date
					</asp:Label>
					<div class="col-md-10" >
						<asp:TextBox CssClass="form-control"
						             ID="publish_date"
						             runat="server"
						             TextMode="Date" >
						</asp:TextBox>
					</div>
				</div>
			</div>
		</div>

		<div class="form-group row" >
			<div class="col-md-10 col-md-offset-2" >
				<asp:Button CssClass="btn btn-primary"
				            ID="btn_submit"
				            runat="server"
				            OnClick="btn_submit_OnClick"
				            Text="Submit" />
			</div>
		</div>
	</div>

</asp:Content>
