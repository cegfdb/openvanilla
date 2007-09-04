using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace OVPreferences
{
    public partial class PanelPhonetic : UserControl
    {
        private OVConfig m_ovConf = null;
        private XmlDocument m_ovConfDOM = null;
        private OVConfigDomWriter m_ovConfDomWriter = null;

        public PanelPhonetic()
        {
            InitializeComponent();
        }

        public virtual void Init(OVConfig conf, XmlDocument confDOM)
        {
            m_ovConf = conf;
            m_ovConfDOM = confDOM;
            m_ovConfDomWriter = new OVConfigDomWriter(m_ovConfDOM);

            LoadSettings();
        }

        public virtual void LoadSettings()
        {
        }
    }
}
