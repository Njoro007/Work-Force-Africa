using System.Collections;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stack_LiFo
{
    public partial class Form1 : Form
    {

        Stack<Panel> _colorStack = new Stack<Panel>();
        Panel p = new Panel();

        public Form1()
        {
            InitializeComponent();
        }

        private Panel RandomColourGenerator(int n)
        {
            //Random rnd = new Random();
            //Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            //return randomColor;

            

            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            Color randomColor = Color.FromKnownColor(randomColorName);

            Panel panel = new Panel();
            panel.Name = $"panelID{n}";
            panel.BackColor = randomColor;

            return panel;
        }

        private void btnRandomStack_Click(object sender, EventArgs e)
        {
            _colorStack.Push(RandomColourGenerator(1));
            _colorStack.Push(RandomColourGenerator(2));
            _colorStack.Push(RandomColourGenerator(3));
            _colorStack.Push(RandomColourGenerator(4));

            int PanelID = 1;
            setBackground(_colorStack);
        }

        private void btnRemoveStackLiFo_Click(object sender, EventArgs e)
        {

            setBackground(_colorStack, true);
        }

        public async void setBackground(Stack<Panel> ColorStack, bool IsRemoved = false)
        {
            List<Control> panelControl = new List<Control>();
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(System.Windows.Forms.Panel))
                {
                    panelControl.Add(control);
                    if (!IsRemoved)
                    {
                        foreach (var obj in ColorStack)
                        {
                            //control.Name = obj;
                            if (control.Name.Equals(obj.Name))
                            {
                                control.BackColor = obj.BackColor;
                            }
                            await Task.Delay(500);
                        }
                    }
                }
            }

            if (IsRemoved)
            {
                foreach (Control control in ReversePanel(panelControl))
                {
                    if (control.GetType() == typeof(System.Windows.Forms.Panel))
                    {

                        ReversePanelColor(ColorStack);

                        foreach (var obj in ColorStack)
                        {
                            if (control.Name.Equals(obj.Name))
                            {
                                control.BackColor = Color.White;
                            }
                            await Task.Delay(500);
                        }
                    }
                }
            }
        }

        public List<Control> ReversePanel(List<Control> panelControls)
        {
            panelControls.Reverse();
            return panelControls;
        }

        public void ReversePanelColor(Stack<Panel> stack)
        {
            if (stack.Count != 0)
            {
                var panel = stack.Pop(); // Store the last element panel object in memory 
                ReversePanelColor(stack); // New stack collection after removing the last element
                RearrangePanelColor(stack, panel); // New stack collection after removing the last element and maintaining the last element reference
            }
        }

        public void RearrangePanelColor(Stack<Panel> stack, Panel panel)
        {
            if (stack.Count == 0)
            {
                stack.Push(panel);
            }
            else
            {
                var panelTemp = stack.Pop(); // Store reference of the last element after the reverse function has popped the stack
                RearrangePanelColor(stack, panel); // Reference after deleting the panel and accessing the panel object for rearrangment
                stack.Push(panelTemp); // store the panel object for rearrangement
            }
        }


    }
}