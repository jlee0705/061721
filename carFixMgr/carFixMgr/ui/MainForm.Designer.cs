
namespace carFixMgr
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.custfixAdd = new CxFlatUI.CxFlatRoundButton();
            this.custfixView = new CxFlatUI.CxFlatRoundButton();
            this.custFixAdmin = new CxFlatUI.CxFlatRoundButton();
            this.custFixInfo = new CxFlatUI.CxFlatRoundButton();
            this.mainExit = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.custFixRand = new CxFlatUI.CxFlatRoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(-1, 65);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(297, 536);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox1.TabIndex = 0;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // custfixAdd
            // 
            this.custfixAdd.ButtonType = CxFlatUI.ButtonType.Primary;
            this.custfixAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custfixAdd.Location = new System.Drawing.Point(333, 95);
            this.custfixAdd.Name = "custfixAdd";
            this.custfixAdd.Size = new System.Drawing.Size(246, 51);
            this.custfixAdd.TabIndex = 1;
            this.custfixAdd.Text = "고객정보 접수";
            this.custfixAdd.TextColor = System.Drawing.Color.White;
            this.custfixAdd.Click += new System.EventHandler(this.custfixAdd_Click_1);
            // 
            // custfixView
            // 
            this.custfixView.ButtonType = CxFlatUI.ButtonType.Success;
            this.custfixView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custfixView.Location = new System.Drawing.Point(420, 171);
            this.custfixView.Name = "custfixView";
            this.custfixView.Size = new System.Drawing.Size(246, 51);
            this.custfixView.TabIndex = 2;
            this.custfixView.Text = "수리 내역";
            this.custfixView.TextColor = System.Drawing.Color.White;
            this.custfixView.Click += new System.EventHandler(this.custFixView_Click);
            // 
            // custFixAdmin
            // 
            this.custFixAdmin.ButtonType = CxFlatUI.ButtonType.Danger;
            this.custFixAdmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custFixAdmin.Location = new System.Drawing.Point(499, 243);
            this.custFixAdmin.Name = "custFixAdmin";
            this.custFixAdmin.Size = new System.Drawing.Size(246, 51);
            this.custFixAdmin.TabIndex = 3;
            this.custFixAdmin.Text = "관리자 모드";
            this.custFixAdmin.TextColor = System.Drawing.Color.White;
            this.custFixAdmin.Click += new System.EventHandler(this.custFixAdmin_Click);
            // 
            // custFixInfo
            // 
            this.custFixInfo.ButtonType = CxFlatUI.ButtonType.Primary;
            this.custFixInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custFixInfo.Location = new System.Drawing.Point(333, 394);
            this.custFixInfo.Name = "custFixInfo";
            this.custFixInfo.Size = new System.Drawing.Size(246, 51);
            this.custFixInfo.TabIndex = 5;
            this.custFixInfo.Text = "앱 정보";
            this.custFixInfo.TextColor = System.Drawing.Color.White;
            this.custFixInfo.Click += new System.EventHandler(this.custFixInfo_Click);
            // 
            // mainExit
            // 
            this.mainExit.BackColor = System.Drawing.Color.Transparent;
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.FillColor = System.Drawing.Color.Transparent;
            this.mainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainExit.ForeHoverColor = System.Drawing.Color.Red;
            this.mainExit.Location = new System.Drawing.Point(817, 28);
            this.mainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainExit.Name = "mainExit";
            this.mainExit.RectColor = System.Drawing.Color.Transparent;
            this.mainExit.Size = new System.Drawing.Size(64, 35);
            this.mainExit.Style = Sunny.UI.UIStyle.Custom;
            this.mainExit.Symbol = 61527;
            this.mainExit.SymbolSize = 30;
            this.mainExit.TabIndex = 6;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(29, 28);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(200, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61881;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.CornflowerBlue;
            this.uiSymbolLabel1.TabIndex = 7;
            this.uiSymbolLabel1.Text = "카센터 관리 앱 v1.0";
            // 
            // custFixRand
            // 
            this.custFixRand.ButtonType = CxFlatUI.ButtonType.Success;
            this.custFixRand.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custFixRand.Location = new System.Drawing.Point(420, 320);
            this.custFixRand.Name = "custFixRand";
            this.custFixRand.Size = new System.Drawing.Size(246, 51);
            this.custFixRand.TabIndex = 8;
            this.custFixRand.Text = "랜덤 데이터 추가";
            this.custFixRand.TextColor = System.Drawing.Color.White;
            this.custFixRand.Click += new System.EventHandler(this.custFixRand_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 604);
            this.ControlBox = false;
            this.Controls.Add(this.custFixRand);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.custFixInfo);
            this.Controls.Add(this.custFixAdmin);
            this.Controls.Add(this.custfixView);
            this.Controls.Add(this.custfixAdd);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Name = "MainForm";
            this.Sizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private CxFlatUI.CxFlatRoundButton custfixAdd;
        private CxFlatUI.CxFlatRoundButton custfixView;
        private CxFlatUI.CxFlatRoundButton custFixAdmin;
        private CxFlatUI.CxFlatRoundButton custFixInfo;
        private Sunny.UI.UISymbolButton mainExit;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private CxFlatUI.CxFlatRoundButton custFixRand;
    }
}

