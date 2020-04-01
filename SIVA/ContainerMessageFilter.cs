using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SIVA
{
    public class ContainerMessageFilter : IMessageFilter
    {
        private const int WM_MOUSEMOVE = 512;
        private readonly IEnumerable<IntPtr> handles;
        private bool insideContainer;

        public ContainerMessageFilter(Control container)
        {
            handles = CollectContainerHandles(container);
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 512)
            {
                if (handles.Contains(m.HWnd))
                {
                    if (!insideContainer)
                    {
                        insideContainer = true;
                        OnMouseEnter(EventArgs.Empty);
                    }
                }
                else if (insideContainer)
                {
                    insideContainer = false;
                    OnMouseLeave(EventArgs.Empty);
                }
            }

            return false;
        }

        public event EventHandler MouseEnter;

        public event EventHandler MouseLeave;

        private static IEnumerable<IntPtr> CollectContainerHandles(Control container)
        {
            var handles = new List<IntPtr> {container.Handle};
            RecurseControls(container.Controls, handles);
            return handles;
        }

        private static void RecurseControls(IEnumerable controls, List<IntPtr> handles)
        {
            foreach (Control control in controls)
            {
                handles.Add(control.Handle);
                RecurseControls(control.Controls, handles);
            }
        }

        protected virtual void OnMouseEnter(EventArgs e)
        {
            var mouseEnter = MouseEnter;
            if (mouseEnter == null)
                return;
            mouseEnter(this, e);
        }

        protected virtual void OnMouseLeave(EventArgs e)
        {
            var mouseLeave = MouseLeave;
            if (mouseLeave == null)
                return;
            mouseLeave(this, e);
        }
    }
}