namespace XsAndOsGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.SessionState;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class XsAndOsGame : System.Web.UI.Page
    {
        private string eImgUrl = "images/e.png";
        private string xImgUrl = "images/x.png";
        private string oImgUrl = "images/o.png";

        private string xPlayerWin = "X-player wins";
        private string oPlayerWin = "O-player wins";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.ViewState["CurrUser"] == null)
            {
                this.ViewState["CurrUser"] = 1;
            }

            if (this.ImgBtn1.ImageUrl == string.Empty)
            {
                this.ImgBtn1.ImageUrl = this.eImgUrl;
            }

            if (this.ImgBtn2.ImageUrl == string.Empty)
            {
                this.ImgBtn2.ImageUrl = this.eImgUrl;
            }

            if (this.ImgBtn3.ImageUrl == string.Empty)
            {
                this.ImgBtn3.ImageUrl = this.eImgUrl;
            }

            if (this.ImgBtn4.ImageUrl == string.Empty)
            {
                ImgBtn4.ImageUrl = this.eImgUrl;
            }

            if (this.ImgBtn5.ImageUrl == string.Empty)
            {
                this.ImgBtn5.ImageUrl = this.eImgUrl;
            }

            if (this.ImgBtn6.ImageUrl == string.Empty)
            {
                this.ImgBtn6.ImageUrl = this.eImgUrl;
            }

            if (this.ImgBtn7.ImageUrl == string.Empty)
            {
                this.ImgBtn7.ImageUrl = this.eImgUrl;
            }

            if (this.ImgBtn8.ImageUrl == string.Empty)
            {
                this.ImgBtn8.ImageUrl = this.eImgUrl;
            }

            if (this.ImgBtn9.ImageUrl == string.Empty)
            {
                this.ImgBtn9.ImageUrl = this.eImgUrl;
            }
        }

        protected void NewGame_Click(object sender, EventArgs e)
        {
            Result.Text = string.Empty;

            ImgBtn1.ImageUrl = this.eImgUrl;
            ImgBtn2.ImageUrl = this.eImgUrl;
            ImgBtn3.ImageUrl = this.eImgUrl;
            ImgBtn4.ImageUrl = this.eImgUrl;
            ImgBtn5.ImageUrl = this.eImgUrl;
            ImgBtn6.ImageUrl = this.eImgUrl;
            ImgBtn7.ImageUrl = this.eImgUrl;
            ImgBtn8.ImageUrl = this.eImgUrl;
            ImgBtn9.ImageUrl = this.eImgUrl;
        }

        protected void ImgBtn1_Click(object sender, ImageClickEventArgs e)
        {
            if ((int)ViewState["CurrUser"] == 1)
            {
                ImgBtn1.ImageUrl = this.xImgUrl;
                this.ViewState["CurrUser"] = 2;
            }
            else
            {
                ImgBtn1.ImageUrl = this.oImgUrl;
                this.ViewState["CurrUser"] = 1;
            }

            this.Check();
        }

        protected void ImgBtn2_Click(object sender, ImageClickEventArgs e)
        {
            if ((int)ViewState["CurrUser"] == 1)
            {
                ImgBtn2.ImageUrl = this.xImgUrl;
                this.ViewState["CurrUser"] = 2;
            }
            else
            {
                ImgBtn2.ImageUrl = this.oImgUrl;
                this.ViewState["CurrUser"] = 1;
            }

            this.Check();
        }

        protected void ImgBtn3_Click(object sender, ImageClickEventArgs e)
        {
            if ((int)ViewState["CurrUser"] == 1)
            {
                ImgBtn3.ImageUrl = this.xImgUrl;
                this.ViewState["CurrUser"] = 2;
            }
            else
            {
                ImgBtn3.ImageUrl = this.oImgUrl;
                this.ViewState["CurrUser"] = 1;
            }

            this.Check();
        }

        protected void ImgBtn4_Click(object sender, ImageClickEventArgs e)
        {
            if ((int)ViewState["CurrUser"] == 1)
            {
                ImgBtn4.ImageUrl = this.xImgUrl;
                this.ViewState["CurrUser"] = 2;
            }
            else
            {
                ImgBtn4.ImageUrl = this.oImgUrl;
                this.ViewState["CurrUser"] = 1;
            }

            this.Check();
        }

        protected void ImgBtn5_Click(object sender, ImageClickEventArgs e)
        {
            if ((int)ViewState["CurrUser"] == 1)
            {
                ImgBtn5.ImageUrl = this.xImgUrl;
                this.ViewState["CurrUser"] = 2;
            }
            else
            {
                ImgBtn5.ImageUrl = this.oImgUrl;
                this.ViewState["CurrUser"] = 1;
            }

            this.Check();
        }

        protected void ImgBtn6_Click(object sender, ImageClickEventArgs e)
        {
            if ((int)ViewState["CurrUser"] == 1)
            {
                ImgBtn6.ImageUrl = this.xImgUrl;
                this.ViewState["CurrUser"] = 2;
            }
            else
            {
                ImgBtn6.ImageUrl = this.oImgUrl;
                this.ViewState["CurrUser"] = 1;
            }

            this.Check();
        }

        protected void ImgBtn7_Click(object sender, ImageClickEventArgs e)
        {
            if ((int)ViewState["CurrUser"] == 1)
            {
                ImgBtn7.ImageUrl = this.xImgUrl;
                this.ViewState["CurrUser"] = 2;
            }
            else
            {
                ImgBtn7.ImageUrl = this.oImgUrl;
                this.ViewState["CurrUser"] = 1;
            }

            this.Check();
        }

        protected void ImgBtn8_Click(object sender, ImageClickEventArgs e)
        {
            if ((int)ViewState["CurrUser"] == 1)
            {
                ImgBtn8.ImageUrl = this.xImgUrl;
                this.ViewState["CurrUser"] = 2;
            }
            else
            {
                ImgBtn8.ImageUrl = this.oImgUrl;
                this.ViewState["CurrUser"] = 1;
            }

            this.Check();
        }

        protected void ImgBtn9_Click(object sender, ImageClickEventArgs e)
        {
            if ((int)ViewState["CurrUser"] == 1)
            {
                ImgBtn9.ImageUrl = this.xImgUrl;
                this.ViewState["CurrUser"] = 2;
            }
            else
            {
                ImgBtn9.ImageUrl = this.oImgUrl;
                this.ViewState["CurrUser"] = 1;
            }

            this.Check();
        }

        protected void Check()
        {
            if (ImgBtn1.ImageUrl == ImgBtn2.ImageUrl && ImgBtn1.ImageUrl == ImgBtn3.ImageUrl)
            {
                if (ImgBtn1.ImageUrl == this.xImgUrl)
                {
                    Result.Text = this.xPlayerWin;
                }
                else if (ImgBtn1.ImageUrl == this.oImgUrl)
                {
                    Result.Text = this.oPlayerWin;
                }
            }

            if (ImgBtn4.ImageUrl == ImgBtn5.ImageUrl && ImgBtn4.ImageUrl == ImgBtn6.ImageUrl)
            {
                if (ImgBtn4.ImageUrl == this.xImgUrl)
                {
                    Result.Text = this.xPlayerWin;
                }
                else if (ImgBtn4.ImageUrl == this.oImgUrl)
                {
                    Result.Text = this.oPlayerWin;
                }
            }

            if (ImgBtn7.ImageUrl == ImgBtn8.ImageUrl && ImgBtn7.ImageUrl == ImgBtn9.ImageUrl)
            {
                if (ImgBtn7.ImageUrl == this.xImgUrl)
                {
                    Result.Text = this.xPlayerWin;
                }
                else if (ImgBtn7.ImageUrl == this.oImgUrl)
                {
                    Result.Text = this.oPlayerWin;
                }
            }

            if (ImgBtn1.ImageUrl == ImgBtn4.ImageUrl && ImgBtn1.ImageUrl == ImgBtn7.ImageUrl)
            {
                if (ImgBtn1.ImageUrl == this.xImgUrl)
                {
                    Result.Text = this.xPlayerWin;
                }
                else if (ImgBtn1.ImageUrl == this.oImgUrl)
                {
                    Result.Text = this.oPlayerWin;
                }
            }

            if (ImgBtn2.ImageUrl == ImgBtn5.ImageUrl && ImgBtn2.ImageUrl == ImgBtn8.ImageUrl)
            {
                if (ImgBtn2.ImageUrl == this.xImgUrl)
                {
                    Result.Text = this.xPlayerWin;
                }
                else if (ImgBtn2.ImageUrl == this.oImgUrl)
                {
                    Result.Text = this.oPlayerWin;
                }
            }

            if (ImgBtn3.ImageUrl == ImgBtn6.ImageUrl && ImgBtn3.ImageUrl == ImgBtn9.ImageUrl)
            {
                if (ImgBtn3.ImageUrl == this.xImgUrl)
                {
                    Result.Text = this.xPlayerWin;
                }
                else if (ImgBtn3.ImageUrl == this.oImgUrl)
                {
                    Result.Text = this.oPlayerWin;
                }
            }

            if (ImgBtn1.ImageUrl == ImgBtn5.ImageUrl && ImgBtn1.ImageUrl == ImgBtn9.ImageUrl)
            {
                if (ImgBtn1.ImageUrl == this.xImgUrl)
                {
                    Result.Text = this.xPlayerWin;
                }
                else if (ImgBtn1.ImageUrl == this.oImgUrl)
                {
                    Result.Text = this.oPlayerWin;
                }
            }

            if (ImgBtn3.ImageUrl == ImgBtn5.ImageUrl && ImgBtn3.ImageUrl == ImgBtn7.ImageUrl)
            {
                if (ImgBtn3.ImageUrl == this.xImgUrl)
                {
                    Result.Text = this.xPlayerWin;
                }
                else if (ImgBtn3.ImageUrl == this.oImgUrl)
                {
                    Result.Text = this.oPlayerWin;
                }
            }
        }
    }
}