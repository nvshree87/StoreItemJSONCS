namespace Test_New
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtRestURL = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.cmdGo = new System.Windows.Forms.Button();
            this.Request_URL = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.Button();
            this.TableStoreItem = new System.Windows.Forms.DataGridView();
            this.cbxVerb = new System.Windows.Forms.ComboBox();
            this.txtPOSTData = new System.Windows.Forms.TextBox();
            this.PostData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TableStoreItem)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtRestURL
            // 
            this.TxtRestURL.Location = new System.Drawing.Point(138, 13);
            this.TxtRestURL.Multiline = true;
            this.TxtRestURL.Name = "TxtRestURL";
            this.TxtRestURL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtRestURL.Size = new System.Drawing.Size(329, 22);
            this.TxtRestURL.TabIndex = 0;
            this.TxtRestURL.Text = "http://www.nutidweboffice.com/bunkersgolfhk/api/assignment";
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(138, 176);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(565, 177);
            this.txtResponse.TabIndex = 1;
            // 
            // cmdGo
            // 
            this.cmdGo.Location = new System.Drawing.Point(646, 10);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(56, 32);
            this.cmdGo.TabIndex = 2;
            this.cmdGo.Text = "Go!";
            this.cmdGo.UseVisualStyleBackColor = true;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // Request_URL
            // 
            this.Request_URL.AutoSize = true;
            this.Request_URL.Location = new System.Drawing.Point(32, 18);
            this.Request_URL.Name = "Request_URL";
            this.Request_URL.Size = new System.Drawing.Size(83, 17);
            this.Request_URL.TabIndex = 3;
            this.Request_URL.Text = "Request Url";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(32, 178);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(65, 17);
            this.Message.TabIndex = 4;
            this.Message.Text = "Message";
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(327, 372);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(172, 23);
            this.Display.TabIndex = 5;
            this.Display.Text = "Display Store Item";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // TableStoreItem
            // 
            this.TableStoreItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableStoreItem.GridColor = System.Drawing.SystemColors.Control;
            this.TableStoreItem.Location = new System.Drawing.Point(139, 414);
            this.TableStoreItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableStoreItem.Name = "TableStoreItem";
            this.TableStoreItem.RowTemplate.Height = 28;
            this.TableStoreItem.Size = new System.Drawing.Size(564, 217);
            this.TableStoreItem.TabIndex = 6;
            this.TableStoreItem.Visible = false;
            // 
            // cbxVerb
            // 
            this.cbxVerb.FormattingEnabled = true;
            this.cbxVerb.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.cbxVerb.Location = new System.Drawing.Point(501, 15);
            this.cbxVerb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxVerb.Name = "cbxVerb";
            this.cbxVerb.Size = new System.Drawing.Size(108, 24);
            this.cbxVerb.TabIndex = 7;
            this.cbxVerb.Text = "GET";
            // 
            // txtPOSTData
            // 
            this.txtPOSTData.Location = new System.Drawing.Point(137, 66);
            this.txtPOSTData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPOSTData.Multiline = true;
            this.txtPOSTData.Name = "txtPOSTData";
            this.txtPOSTData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPOSTData.Size = new System.Drawing.Size(565, 78);
            this.txtPOSTData.TabIndex = 8;
            this.txtPOSTData.Text = resources.GetString("txtPOSTData.Text");
            // 
            // PostData
            // 
            this.PostData.AutoSize = true;
            this.PostData.Location = new System.Drawing.Point(32, 76);
            this.PostData.Name = "PostData";
            this.PostData.Size = new System.Drawing.Size(66, 17);
            this.PostData.TabIndex = 9;
            this.PostData.Text = "PostData";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(772, 665);
            this.Controls.Add(this.PostData);
            this.Controls.Add(this.txtPOSTData);
            this.Controls.Add(this.cbxVerb);
            this.Controls.Add(this.TableStoreItem);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Request_URL);
            this.Controls.Add(this.cmdGo);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.TxtRestURL);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "Form1";
            this.Text = "JSONandRestAPI";
            ((System.ComponentModel.ISupportInitialize)(this.TableStoreItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtRestURL;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button cmdGo;
        private System.Windows.Forms.Label Request_URL;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.DataGridView TableStoreItem;
        private System.Windows.Forms.ComboBox cbxVerb;
        private System.Windows.Forms.TextBox txtPOSTData;
        private System.Windows.Forms.Label PostData;
    }
}

