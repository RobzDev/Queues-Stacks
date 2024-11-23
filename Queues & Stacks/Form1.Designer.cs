namespace Queues___Stacks
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtInput = new TextBox();
            txtStack = new TextBox();
            txtQueue = new TextBox();
            btnPush = new Button();
            btnPop = new Button();
            btnEnqueue = new Button();
            btnDequeue = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(20, 20);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 0;
            // 
            // txtStack
            // 
            txtStack.Location = new Point(20, 100);
            txtStack.Multiline = true;
            txtStack.Name = "txtStack";
            txtStack.ReadOnly = true;
            txtStack.Size = new Size(200, 80);
            txtStack.TabIndex = 1;
            // 
            // txtQueue
            // 
            txtQueue.Location = new Point(250, 100);
            txtQueue.Multiline = true;
            txtQueue.Name = "txtQueue";
            txtQueue.ReadOnly = true;
            txtQueue.Size = new Size(200, 80);
            txtQueue.TabIndex = 2;
            // 
            // btnPush
            // 
            btnPush.Location = new Point(20, 60);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(75, 23);
            btnPush.TabIndex = 3;
            btnPush.Text = "Push";
            btnPush.Click += btnPush_Click;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(120, 60);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(75, 23);
            btnPop.TabIndex = 4;
            btnPop.Text = "Pop";
            btnPop.Click += btnPop_Click;
            // 
            // btnEnqueue
            // 
            btnEnqueue.Location = new Point(250, 60);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(75, 23);
            btnEnqueue.TabIndex = 5;
            btnEnqueue.Text = "Enqueue";
            btnEnqueue.Click += btnEnqueue_Click;
            // 
            // btnDequeue
            // 
            btnDequeue.Location = new Point(350, 60);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(75, 23);
            btnDequeue.TabIndex = 6;
            btnDequeue.Text = "Dequeue";
            btnDequeue.Click += btnDequeue_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(480, 220);
            Controls.Add(txtInput);
            Controls.Add(txtStack);
            Controls.Add(txtQueue);
            Controls.Add(btnPush);
            Controls.Add(btnPop);
            Controls.Add(btnEnqueue);
            Controls.Add(btnDequeue);
            Name = "Form1";
            Text = "Pilas y Colas";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtStack;
        private System.Windows.Forms.TextBox txtQueue;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.Button btnDequeue;
    }
}
