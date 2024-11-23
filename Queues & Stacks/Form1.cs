namespace Queues___Stacks
{
    public partial class Form1 : Form
    {
        private Stack stack;
        private Queue queue;
        public Form1()
        {
            InitializeComponent();
            stack = new Stack(5); // Pila con capacidad de 5 elementos
            queue = new Queue(5); // Co
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                stack.Push(value);
                UpdateStackDisplay();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            int result = stack.Pop();
            if (result != -1)
                UpdateStackDisplay();
        }

        // Operaciones con la Cola
        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                queue.Enqueue(value);
                UpdateQueueDisplay();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            int result = queue.Dequeue();
            if (result != -1)
                UpdateQueueDisplay();
        }

        // Métodos para actualizar las cajas de texto
        private void UpdateStackDisplay()
        {
            txtStack.Text = stack.GetElements();
        }

        private void UpdateQueueDisplay()
        {
            txtQueue.Text = queue.GetElements();
        }
    }

    // Implementación de la Pila
    public class Stack
    {
        private int[] elements;
        private int top;

        public Stack(int size)
        {
            elements = new int[size];
            top = -1;
        }

        public void Push(int value)
        {
            if (top == elements.Length - 1)
            {
                MessageBox.Show("La pila está llena.");
                return;
            }
            elements[++top] = value;
        }

        public int Pop()
        {
            if (top == -1)
            {
                MessageBox.Show("La pila está vacía.");
                return -1;
            }
            return elements[top--];
        }

        public string GetElements()
        {
            if (top == -1) return "Pila vacía.";
            string result = "";
            for (int i = 0; i <= top; i++)
                result += elements[i] + " ";
            return result.Trim();
        }
    }

    // Implementación de la Cola
    public class Queue
    {
        private int[] elements;
        private int front, rear;

        public Queue(int size)
        {
            elements = new int[size];
            front = 0;
            rear = -1;
        }

        public void Enqueue(int value)
        {
            if (rear == elements.Length - 1)
            {
                MessageBox.Show("La cola está llena.");
                return;
            }
            elements[++rear] = value;
        }

        public int Dequeue()
        {
            if (front > rear)
            {
                MessageBox.Show("La cola está vacía.");
                return -1;
            }
            return elements[front++];
        }

        public string GetElements()
        {
            if (front > rear) return "Cola vacía.";
            string result = "";
            for (int i = front; i <= rear; i++)
                result += elements[i] + " ";
            return result.Trim();
        }
    }
}
