﻿//*******************************************************************************************************
//  InputWizard.xaml.cs - Gbtc
//
//  Tennessee Valley Authority, 2009
//  No copyright is claimed pursuant to 17 USC § 105.  All Other Rights Reserved.
//
//  This software is made freely available under the TVA Open Source Agreement (see below).
//
//  Code Modification History:
//  -----------------------------------------------------------------------------------------------------
//  11/04/2009 - Mehulbhai P. Thakkar
//       Generated original version of source code.
//
//*******************************************************************************************************

#region [ TVA Open Source Agreement ]
/*

 THIS OPEN SOURCE AGREEMENT ("AGREEMENT") DEFINES THE RIGHTS OF USE,REPRODUCTION, DISTRIBUTION,
 MODIFICATION AND REDISTRIBUTION OF CERTAIN COMPUTER SOFTWARE ORIGINALLY RELEASED BY THE
 TENNESSEE VALLEY AUTHORITY, A CORPORATE AGENCY AND INSTRUMENTALITY OF THE UNITED STATES GOVERNMENT
 ("GOVERNMENT AGENCY"). GOVERNMENT AGENCY IS AN INTENDED THIRD-PARTY BENEFICIARY OF ALL SUBSEQUENT
 DISTRIBUTIONS OR REDISTRIBUTIONS OF THE SUBJECT SOFTWARE. ANYONE WHO USES, REPRODUCES, DISTRIBUTES,
 MODIFIES OR REDISTRIBUTES THE SUBJECT SOFTWARE, AS DEFINED HEREIN, OR ANY PART THEREOF, IS, BY THAT
 ACTION, ACCEPTING IN FULL THE RESPONSIBILITIES AND OBLIGATIONS CONTAINED IN THIS AGREEMENT.

 Original Software Designation: openPDC
 Original Software Title: The TVA Open Source Phasor Data Concentrator
 User Registration Requested. Please Visit https://naspi.tva.com/Registration/
 Point of Contact for Original Software: J. Ritchie Carroll <mailto:jrcarrol@tva.gov>

 1. DEFINITIONS

 A. "Contributor" means Government Agency, as the developer of the Original Software, and any entity
 that makes a Modification.

 B. "Covered Patents" mean patent claims licensable by a Contributor that are necessarily infringed by
 the use or sale of its Modification alone or when combined with the Subject Software.

 C. "Display" means the showing of a copy of the Subject Software, either directly or by means of an
 image, or any other device.

 D. "Distribution" means conveyance or transfer of the Subject Software, regardless of means, to
 another.

 E. "Larger Work" means computer software that combines Subject Software, or portions thereof, with
 software separate from the Subject Software that is not governed by the terms of this Agreement.

 F. "Modification" means any alteration of, including addition to or deletion from, the substance or
 structure of either the Original Software or Subject Software, and includes derivative works, as that
 term is defined in the Copyright Statute, 17 USC § 101. However, the act of including Subject Software
 as part of a Larger Work does not in and of itself constitute a Modification.

 G. "Original Software" means the computer software first released under this Agreement by Government
 Agency entitled openPDC, including source code, object code and accompanying documentation, if any.

 H. "Recipient" means anyone who acquires the Subject Software under this Agreement, including all
 Contributors.

 I. "Redistribution" means Distribution of the Subject Software after a Modification has been made.

 J. "Reproduction" means the making of a counterpart, image or copy of the Subject Software.

 K. "Sale" means the exchange of the Subject Software for money or equivalent value.

 L. "Subject Software" means the Original Software, Modifications, or any respective parts thereof.

 M. "Use" means the application or employment of the Subject Software for any purpose.

 2. GRANT OF RIGHTS

 A. Under Non-Patent Rights: Subject to the terms and conditions of this Agreement, each Contributor,
 with respect to its own contribution to the Subject Software, hereby grants to each Recipient a
 non-exclusive, world-wide, royalty-free license to engage in the following activities pertaining to
 the Subject Software:

 1. Use

 2. Distribution

 3. Reproduction

 4. Modification

 5. Redistribution

 6. Display

 B. Under Patent Rights: Subject to the terms and conditions of this Agreement, each Contributor, with
 respect to its own contribution to the Subject Software, hereby grants to each Recipient under Covered
 Patents a non-exclusive, world-wide, royalty-free license to engage in the following activities
 pertaining to the Subject Software:

 1. Use

 2. Distribution

 3. Reproduction

 4. Sale

 5. Offer for Sale

 C. The rights granted under Paragraph B. also apply to the combination of a Contributor's Modification
 and the Subject Software if, at the time the Modification is added by the Contributor, the addition of
 such Modification causes the combination to be covered by the Covered Patents. It does not apply to
 any other combinations that include a Modification. 

 D. The rights granted in Paragraphs A. and B. allow the Recipient to sublicense those same rights.
 Such sublicense must be under the same terms and conditions of this Agreement.

 3. OBLIGATIONS OF RECIPIENT

 A. Distribution or Redistribution of the Subject Software must be made under this Agreement except for
 additions covered under paragraph 3H. 

 1. Whenever a Recipient distributes or redistributes the Subject Software, a copy of this Agreement
 must be included with each copy of the Subject Software; and

 2. If Recipient distributes or redistributes the Subject Software in any form other than source code,
 Recipient must also make the source code freely available, and must provide with each copy of the
 Subject Software information on how to obtain the source code in a reasonable manner on or through a
 medium customarily used for software exchange.

 B. Each Recipient must ensure that the following copyright notice appears prominently in the Subject
 Software:

          No copyright is claimed pursuant to 17 USC § 105.  All Other Rights Reserved.

 C. Each Contributor must characterize its alteration of the Subject Software as a Modification and
 must identify itself as the originator of its Modification in a manner that reasonably allows
 subsequent Recipients to identify the originator of the Modification. In fulfillment of these
 requirements, Contributor must include a file (e.g., a change log file) that describes the alterations
 made and the date of the alterations, identifies Contributor as originator of the alterations, and
 consents to characterization of the alterations as a Modification, for example, by including a
 statement that the Modification is derived, directly or indirectly, from Original Software provided by
 Government Agency. Once consent is granted, it may not thereafter be revoked.

 D. A Contributor may add its own copyright notice to the Subject Software. Once a copyright notice has
 been added to the Subject Software, a Recipient may not remove it without the express permission of
 the Contributor who added the notice.

 E. A Recipient may not make any representation in the Subject Software or in any promotional,
 advertising or other material that may be construed as an endorsement by Government Agency or by any
 prior Recipient of any product or service provided by Recipient, or that may seek to obtain commercial
 advantage by the fact of Government Agency's or a prior Recipient's participation in this Agreement.

 F. In an effort to track usage and maintain accurate records of the Subject Software, each Recipient,
 upon receipt of the Subject Software, is requested to register with Government Agency by visiting the
 following website: https://naspi.tva.com/Registration/. Recipient's name and personal information
 shall be used for statistical purposes only. Once a Recipient makes a Modification available, it is
 requested that the Recipient inform Government Agency at the web site provided above how to access the
 Modification.

 G. Each Contributor represents that that its Modification does not violate any existing agreements,
 regulations, statutes or rules, and further that Contributor has sufficient rights to grant the rights
 conveyed by this Agreement.

 H. A Recipient may choose to offer, and to charge a fee for, warranty, support, indemnity and/or
 liability obligations to one or more other Recipients of the Subject Software. A Recipient may do so,
 however, only on its own behalf and not on behalf of Government Agency or any other Recipient. Such a
 Recipient must make it absolutely clear that any such warranty, support, indemnity and/or liability
 obligation is offered by that Recipient alone. Further, such Recipient agrees to indemnify Government
 Agency and every other Recipient for any liability incurred by them as a result of warranty, support,
 indemnity and/or liability offered by such Recipient.

 I. A Recipient may create a Larger Work by combining Subject Software with separate software not
 governed by the terms of this agreement and distribute the Larger Work as a single product. In such
 case, the Recipient must make sure Subject Software, or portions thereof, included in the Larger Work
 is subject to this Agreement.

 J. Notwithstanding any provisions contained herein, Recipient is hereby put on notice that export of
 any goods or technical data from the United States may require some form of export license from the
 U.S. Government. Failure to obtain necessary export licenses may result in criminal liability under
 U.S. laws. Government Agency neither represents that a license shall not be required nor that, if
 required, it shall be issued. Nothing granted herein provides any such export license.

 4. DISCLAIMER OF WARRANTIES AND LIABILITIES; WAIVER AND INDEMNIFICATION

 A. No Warranty: THE SUBJECT SOFTWARE IS PROVIDED "AS IS" WITHOUT ANY WARRANTY OF ANY KIND, EITHER
 EXPRESSED, IMPLIED, OR STATUTORY, INCLUDING, BUT NOT LIMITED TO, ANY WARRANTY THAT THE SUBJECT
 SOFTWARE WILL CONFORM TO SPECIFICATIONS, ANY IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
 PARTICULAR PURPOSE, OR FREEDOM FROM INFRINGEMENT, ANY WARRANTY THAT THE SUBJECT SOFTWARE WILL BE ERROR
 FREE, OR ANY WARRANTY THAT DOCUMENTATION, IF PROVIDED, WILL CONFORM TO THE SUBJECT SOFTWARE. THIS
 AGREEMENT DOES NOT, IN ANY MANNER, CONSTITUTE AN ENDORSEMENT BY GOVERNMENT AGENCY OR ANY PRIOR
 RECIPIENT OF ANY RESULTS, RESULTING DESIGNS, HARDWARE, SOFTWARE PRODUCTS OR ANY OTHER APPLICATIONS
 RESULTING FROM USE OF THE SUBJECT SOFTWARE. FURTHER, GOVERNMENT AGENCY DISCLAIMS ALL WARRANTIES AND
 LIABILITIES REGARDING THIRD-PARTY SOFTWARE, IF PRESENT IN THE ORIGINAL SOFTWARE, AND DISTRIBUTES IT
 "AS IS."

 B. Waiver and Indemnity: RECIPIENT AGREES TO WAIVE ANY AND ALL CLAIMS AGAINST GOVERNMENT AGENCY, ITS
 AGENTS, EMPLOYEES, CONTRACTORS AND SUBCONTRACTORS, AS WELL AS ANY PRIOR RECIPIENT. IF RECIPIENT'S USE
 OF THE SUBJECT SOFTWARE RESULTS IN ANY LIABILITIES, DEMANDS, DAMAGES, EXPENSES OR LOSSES ARISING FROM
 SUCH USE, INCLUDING ANY DAMAGES FROM PRODUCTS BASED ON, OR RESULTING FROM, RECIPIENT'S USE OF THE
 SUBJECT SOFTWARE, RECIPIENT SHALL INDEMNIFY AND HOLD HARMLESS  GOVERNMENT AGENCY, ITS AGENTS,
 EMPLOYEES, CONTRACTORS AND SUBCONTRACTORS, AS WELL AS ANY PRIOR RECIPIENT, TO THE EXTENT PERMITTED BY
 LAW.  THE FOREGOING RELEASE AND INDEMNIFICATION SHALL APPLY EVEN IF THE LIABILITIES, DEMANDS, DAMAGES,
 EXPENSES OR LOSSES ARE CAUSED, OCCASIONED, OR CONTRIBUTED TO BY THE NEGLIGENCE, SOLE OR CONCURRENT, OF
 GOVERNMENT AGENCY OR ANY PRIOR RECIPIENT.  RECIPIENT'S SOLE REMEDY FOR ANY SUCH MATTER SHALL BE THE
 IMMEDIATE, UNILATERAL TERMINATION OF THIS AGREEMENT.

 5. GENERAL TERMS

 A. Termination: This Agreement and the rights granted hereunder will terminate automatically if a
 Recipient fails to comply with these terms and conditions, and fails to cure such noncompliance within
 thirty (30) days of becoming aware of such noncompliance. Upon termination, a Recipient agrees to
 immediately cease use and distribution of the Subject Software. All sublicenses to the Subject
 Software properly granted by the breaching Recipient shall survive any such termination of this
 Agreement.

 B. Severability: If any provision of this Agreement is invalid or unenforceable under applicable law,
 it shall not affect the validity or enforceability of the remainder of the terms of this Agreement.

 C. Applicable Law: This Agreement shall be subject to United States federal law only for all purposes,
 including, but not limited to, determining the validity of this Agreement, the meaning of its
 provisions and the rights, obligations and remedies of the parties.

 D. Entire Understanding: This Agreement constitutes the entire understanding and agreement of the
 parties relating to release of the Subject Software and may not be superseded, modified or amended
 except by further written agreement duly executed by the parties.

 E. Binding Authority: By accepting and using the Subject Software under this Agreement, a Recipient
 affirms its authority to bind the Recipient to all terms and conditions of this Agreement and that
 Recipient hereby agrees to all terms and conditions herein.

 F. Point of Contact: Any Recipient contact with Government Agency is to be directed to the designated
 representative as follows: J. Ritchie Carroll <mailto:jrcarrol@tva.gov>.

*/
#endregion

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using openPDCManager.Silverlight.PhasorDataServiceProxy;
using openPDCManager.Silverlight.Utilities;
using openPDCManager.Silverlight.ModalDialogs;

namespace openPDCManager.Silverlight.Pages.Devices
{
	public partial class InputWizard : Page
	{		
		PhasorDataServiceClient client;
		Stream configFileData, connectionFileData, iniFileData;
		ConnectionSettings connectionSettings;
		ObservableCollection<WizardDeviceInfo> wizardDeviceInfoList;
		Dictionary<int, string> vendorDeviceList;
		int? parentID = null;
		string iniFileName = string.Empty;
		string iniFilePath = string.Empty;
		
		public InputWizard()
		{
			InitializeComponent();
			//Services Events			
			client = Common.GetPhasorDataServiceProxyClient();
			client.GetProtocolsCompleted += new EventHandler<GetProtocolsCompletedEventArgs>(client_GetProtocolsCompleted);
			client.GetVendorDevicesCompleted += new EventHandler<GetVendorDevicesCompletedEventArgs>(client_GetVendorDevicesCompleted);
			client.GetCompaniesCompleted += new EventHandler<GetCompaniesCompletedEventArgs>(client_GetCompaniesCompleted);
			client.GetHistoriansCompleted += new EventHandler<GetHistoriansCompletedEventArgs>(client_GetHistoriansCompleted);
			client.GetInterconnectionsCompleted += new EventHandler<GetInterconnectionsCompletedEventArgs>(client_GetInterconnectionsCompleted);
			client.GetConnectionSettingsCompleted += new EventHandler<GetConnectionSettingsCompletedEventArgs>(client_GetConnectionSettingsCompleted);
			client.GetWizardConfigurationInfoCompleted += new EventHandler<GetWizardConfigurationInfoCompletedEventArgs>(client_GetWizardConfigurationInfoCompleted);
			client.SaveWizardConfigurationInfoCompleted += new EventHandler<SaveWizardConfigurationInfoCompletedEventArgs>(client_SaveWizardConfigurationInfoCompleted);
			client.GetDeviceByAcronymCompleted += new EventHandler<GetDeviceByAcronymCompletedEventArgs>(client_GetDeviceByAcronymCompleted);
			client.SaveDeviceCompleted += new EventHandler<SaveDeviceCompletedEventArgs>(client_SaveDeviceCompleted);
			client.GetExecutingAssemblyPathCompleted += new EventHandler<GetExecutingAssemblyPathCompletedEventArgs>(client_GetExecutingAssemblyPathCompleted);
			client.SaveIniFileCompleted += new EventHandler<SaveIniFileCompletedEventArgs>(client_SaveIniFileCompleted);
			//Controls Events
			Loaded += new RoutedEventHandler(InputWizard_Loaded);
			ButtonBrowseConfigurationFile.Click += new RoutedEventHandler(ButtonBrowseConfigurationFile_Click);
			ButtonBrowseConnectionFile.Click += new RoutedEventHandler(ButtonBrowseConnectionFile_Click);
			ButtonBrowseIniFile.Click += new RoutedEventHandler(ButtonBrowseIniFile_Click);
			ButtonNext.Click += new RoutedEventHandler(ButtonNext_Click);
			ButtonPrevious.Click += new RoutedEventHandler(ButtonPrevious_Click);
			AccordianWizard.SelectionChanged += new SelectionChangedEventHandler(AccordianWizard_SelectionChanged);
			CheckboxConnectToPDC.Checked += new RoutedEventHandler(CheckboxConnectToPDC_Checked);
			CheckboxConnectToPDC.Unchecked += new RoutedEventHandler(CheckboxConnectToPDC_Unchecked);
			ComboboxProtocol.SelectionChanged += new SelectionChangedEventHandler(ComboboxProtocol_SelectionChanged);
		}

		
		#region " Service Event Handlers"

		void client_SaveIniFileCompleted(object sender, SaveIniFileCompletedEventArgs e)
		{
			Message message = new Message();
			if (e.Error == null)
			{
				message = Common.ParseStringToMessage(e.Result);
				if (message.UserMessageType == MessageType.Error)	//we will display popup dialog only if it is an error.
				{
					iniFileName = string.Empty;
					SystemMessages sm = new SystemMessages(message, ButtonType.OkOnly);
					sm.Show();
				}
				else
					iniFileName = message.UserMessage;
			}
			else
			{
				message.UserMessageType = MessageType.Error;
				message.UserMessage = "Failed to Upload INI File";
				message.SystemMessage = e.Error.Message;
				SystemMessages sm = new SystemMessages(message, ButtonType.OkOnly);
				sm.Show();
			}
		}

		void client_GetExecutingAssemblyPathCompleted(object sender, GetExecutingAssemblyPathCompletedEventArgs e)
		{
			Message message = new Message();
			if (e.Error == null)
			{
				message = Common.ParseStringToMessage(e.Result);
				if (message.UserMessageType == MessageType.Error)
				{
					iniFilePath = string.Empty;
					SystemMessages sm = new SystemMessages(message, ButtonType.OkOnly);
					sm.Show();
				}
				else
					iniFilePath = message.UserMessage;
			}
			else
			{
				message.UserMessageType = MessageType.Error;
				message.UserMessage = "Failed to Retrieve Current Execution Path";
				message.SystemMessage = e.Error.Message;
				SystemMessages sm = new SystemMessages(message, ButtonType.OkOnly);
				sm.Show();
			}
		}
		void client_GetInterconnectionsCompleted(object sender, GetInterconnectionsCompletedEventArgs e)
		{
			if (e.Error == null)
				ComboboxInterconnection.ItemsSource = e.Result;
			else
				MessageBox.Show(e.Error.Message);
			if (ComboboxInterconnection.Items.Count > 0)
				ComboboxInterconnection.SelectedIndex = 0;
		}
		void client_GetHistoriansCompleted(object sender, GetHistoriansCompletedEventArgs e)
		{
			if (e.Error == null)
				ComboboxHistorian.ItemsSource = e.Result;
			else
				MessageBox.Show(e.Error.Message);
			if (ComboboxHistorian.Items.Count > 0)
				ComboboxHistorian.SelectedIndex = 0;
		}
		void client_GetCompaniesCompleted(object sender, GetCompaniesCompletedEventArgs e)
		{
			if (e.Error == null)
				ComboboxCompany.ItemsSource = e.Result;
			else
				MessageBox.Show(e.Error.Message);
			if (ComboboxCompany.Items.Count > 0)
				ComboboxCompany.SelectedIndex = 0;
		}
		void client_GetVendorDevicesCompleted(object sender, GetVendorDevicesCompletedEventArgs e)
		{
			if (e.Error == null)
			{
				vendorDeviceList = e.Result;
				ComboboxPDCVendor.ItemsSource = vendorDeviceList;
			}
			else
				MessageBox.Show(e.Error.Message);
			if (ComboboxPDCVendor.Items.Count > 0)
				ComboboxPDCVendor.SelectedIndex = 0;
		}
		void client_GetProtocolsCompleted(object sender, GetProtocolsCompletedEventArgs e)
		{
			if (e.Error == null)
				ComboboxProtocol.ItemsSource = e.Result;
			else
				MessageBox.Show(e.Error.Message);
			if (ComboboxProtocol.Items.Count > 0)
				ComboboxProtocol.SelectedIndex = 0;
		}
		void client_GetConnectionSettingsCompleted(object sender, GetConnectionSettingsCompletedEventArgs e)
		{
			if (e.Error == null)
			{
				connectionSettings = e.Result;
				if (connectionSettings != null)
					TextBoxConnectionString.Text = connectionSettings.ConnectionString;
			}
			else
				MessageBox.Show(e.Error.Message);
		}
		void client_GetWizardConfigurationInfoCompleted(object sender, GetWizardConfigurationInfoCompletedEventArgs e)
		{
			if (e.Error == null)
			{
				wizardDeviceInfoList = e.Result;
				ItemControlDeviceList.ItemsSource = wizardDeviceInfoList;
			}
			else
				MessageBox.Show(e.Error.Message);
		}		
		void client_SaveWizardConfigurationInfoCompleted(object sender, SaveWizardConfigurationInfoCompletedEventArgs e)
		{
			Message message = new Message();
			if (e.Error == null)			
				message = Common.ParseStringToMessage(e.Result);							
			else
			{
				message.UserMessageType = MessageType.Error;
				message.UserMessage = "Failed to Save Configuration Information";
				message.SystemMessage = e.Error.Message;				
			}
			SystemMessages sm = new SystemMessages(message, ButtonType.OkOnly);
			sm.Show();
		}
		void client_GetDeviceByAcronymCompleted(object sender, GetDeviceByAcronymCompletedEventArgs e)
		{
			if (e.Error == null)
			{
				Device device = new Device();
				device = e.Result;
				if (device != null && device.IsConcentrator)
					parentID = device.ID;
				else	// means PDC does not exist. if (parentID == null)
				{
					App app = (App)Application.Current;
					device = new Device();
					device.Name = TextBoxPDCName.Text;
					device.Acronym = TextBoxPDCAcronym.Text;
					device.IsConcentrator = true;
					device.VendorDeviceID = ((KeyValuePair<int, string>)ComboboxPDCVendor.SelectedItem).Key == 0 ? (int?)null : ((KeyValuePair<int, string>)ComboboxPDCVendor.SelectedItem).Key;
					device.AccessID = wizardDeviceInfoList.Count > 0 ? wizardDeviceInfoList[0].ParentAccessID : 0;
					device.NodeID = app.NodeValue;
					device.ParentID = null;
					device.Longitude = 0;
					device.Latitude = 0;
					device.CompanyID = ((KeyValuePair<int, string>)ComboboxCompany.SelectedItem).Key == 0 ? (int?)null : ((KeyValuePair<int, string>)ComboboxCompany.SelectedItem).Key;
					device.ProtocolID = ((KeyValuePair<int, string>)ComboboxProtocol.SelectedItem).Key == 0 ? (int?)null : ((KeyValuePair<int, string>)ComboboxProtocol.SelectedItem).Key;
					device.HistorianID = ((KeyValuePair<int, string>)ComboboxHistorian.SelectedItem).Key == 0 ? (int?)null : ((KeyValuePair<int, string>)ComboboxHistorian.SelectedItem).Key;
					device.InterconnectionID = ((KeyValuePair<int, string>)ComboboxInterconnection.SelectedItem).Key == 0 ? (int?)null : ((KeyValuePair<int, string>)ComboboxInterconnection.SelectedItem).Key;
					device.ConnectionString = TextBoxConnectionString.Text;
					device.TimeZone = string.Empty;
					device.TimeAdjustmentTicks = 0;
					device.DataLossInterval = 35;
					device.MeasuredLines = wizardDeviceInfoList.Count;
					device.LoadOrder = 0;
					device.ContactList = string.Empty;
					device.Enabled = true;
					client.SaveDeviceAsync(device, true);
				}
			}
			else
				MessageBox.Show(e.Error.Message);
		}
		void client_SaveDeviceCompleted(object sender, SaveDeviceCompletedEventArgs e)
		{
			if (e.Error == null)
				client.GetDeviceByAcronymAsync(TextBoxPDCAcronym.Text);	// calling this again would set parentID needed in the final step of the wizard.
			else
				MessageBox.Show(e.Error.Message);
		}

		#endregion

		#region " Controls Event Handlers"

		void ComboboxProtocol_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			//If BPA PDC Stream protocol is selected, then ask users to upload their INI file.
			if (((KeyValuePair<int, string>)ComboboxProtocol.SelectedItem).Value.ToUpper().Contains("BPA"))
				IniFileUploadVisualization(Visibility.Visible);
			else
				IniFileUploadVisualization(Visibility.Collapsed);
		}
		void CheckboxConnectToPDC_Unchecked(object sender, RoutedEventArgs e)
		{
			PdcInfoVisualization(Visibility.Collapsed);
		}
		void CheckboxConnectToPDC_Checked(object sender, RoutedEventArgs e)
		{
			PdcInfoVisualization(Visibility.Visible);
		}
		void AccordianWizard_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (AccordianWizard.SelectedIndex == 0)
			{
				ButtonPrevious.Visibility = Visibility.Collapsed;
				ButtonNext.Tag = "Next";
			}
			else if (AccordianWizard.SelectedIndex == AccordianWizard.Items.Count - 1)
			{
				ButtonPrevious.Visibility = Visibility.Visible;
				ButtonNext.Tag = "Finish";
			}
			else
			{
				ButtonNext.Tag = "Next";
				ButtonPrevious.Visibility = Visibility.Visible;
			}
		}		
		void ButtonBrowseIniFile_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = false;
			openFileDialog.Filter = "INI Files (*.ini)|*.ini|All Files (*.*)|*.*";
			bool? result = openFileDialog.ShowDialog();
			if (result != null && result == true)
			{
				TextBoxIniFile.Text = openFileDialog.File.Name;
				iniFileName = openFileDialog.File.Name;
				iniFileData = openFileDialog.File.OpenRead();
				client.SaveIniFileAsync(ReadFileBytes(iniFileData));
				//UploadIniFile(iniFileName, iniFileData);
			}
		}
		void ButtonBrowseConnectionFile_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = false;
			openFileDialog.Filter = "PMU Connection Files (*.PmuConnection)|*.PmuConnection|All Files (*.*)|*.*";
			bool? result = openFileDialog.ShowDialog();
			if (result != null && result == true)
			{
				TextBoxConnectionFile.Text = openFileDialog.File.Name;
				connectionFileData = openFileDialog.File.OpenRead();
				client.GetConnectionSettingsAsync(ReadFileBytes(connectionFileData));
			}
		}
		void ButtonBrowseConfigurationFile_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = false;
			openFileDialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
			bool? result = openFileDialog.ShowDialog();
			if (result != null && result == true)
			{
				TextBoxConfigurationFile.Text = openFileDialog.File.Name;
				configFileData = openFileDialog.File.OpenRead();
				//client.GetWizardConfigurationInfoAsync(ReadFileBytes(configFileData));
			}
		}
		void ButtonPrevious_Click(object sender, RoutedEventArgs e)
		{
			if (AccordianWizard.SelectedIndex > 0)
			{
				AccordionItem item = AccordianWizard.Items[AccordianWizard.SelectedIndex - 1] as AccordionItem;
				item.IsSelected = true;
			}
		}
		void ButtonNext_Click(object sender, RoutedEventArgs e)
		{
			if (AccordianWizard.SelectedIndex == 0)	//we will wait till user clicks next on the first screen to read config file becuase INI file may play a role before we can read config file.
			{
				if ((((KeyValuePair<int, string>)ComboboxProtocol.SelectedItem).Value.ToUpper().Contains("BPA")) && !string.IsNullOrEmpty(iniFileName))
				{
					string configFileDataString = (new StreamReader(configFileData)).ReadToEnd();

					string leftPart = configFileDataString.Substring(0, configFileDataString.IndexOf("</configurationFileName>"));
					string rightPart = configFileDataString.Substring(configFileDataString.IndexOf("</configurationFileName>"));
					leftPart = leftPart.Substring(0, leftPart.LastIndexOf(">") + 1);

					configFileDataString = leftPart + iniFilePath + "\\" + iniFileName + rightPart;

					Byte[] fileData = Encoding.UTF8.GetBytes(configFileDataString);
					MemoryStream ms = new MemoryStream();
					ms.Write(fileData, 0, fileData.Length);
					ms.Position = 0;
					client.GetWizardConfigurationInfoAsync(ReadFileBytes(ms));
				}
				else
					client.GetWizardConfigurationInfoAsync(ReadFileBytes(configFileData));
			}

			if (AccordianWizard.SelectedIndex == 1 && ((bool)CheckboxConnectToPDC.IsChecked))	//we'll check this on second screen instead of first because second screen will give us company information, historian etc.
					client.GetDeviceByAcronymAsync(TextBoxPDCAcronym.Text.Replace(" ", "").ToUpper());

			if (AccordianWizard.SelectedIndex == AccordianWizard.Items.Count - 1)
			{
				App app = (App)Application.Current;
				int? protocolID = ((KeyValuePair<int, string>)ComboboxProtocol.SelectedItem).Key == 0 ? (int?)null : ((KeyValuePair<int, string>)ComboboxProtocol.SelectedItem).Key;
				int? companyID = ((KeyValuePair<int, string>)ComboboxCompany.SelectedItem).Key == 0 ? (int?)null : ((KeyValuePair<int, string>)ComboboxCompany.SelectedItem).Key;
				int? historianID = ((KeyValuePair<int, string>)ComboboxHistorian.SelectedItem).Key == 0 ? (int?)null : ((KeyValuePair<int, string>)ComboboxHistorian.SelectedItem).Key;
				int? interconnectionID = ((KeyValuePair<int, string>)ComboboxInterconnection.SelectedItem).Key == 0 ? (int?)null : ((KeyValuePair<int, string>)ComboboxInterconnection.SelectedItem).Key;
				client.SaveWizardConfigurationInfoAsync(app.NodeValue, wizardDeviceInfoList, TextBoxConnectionString.Text, protocolID, companyID, historianID, interconnectionID, parentID);
			}

			if (AccordianWizard.SelectedIndex < AccordianWizard.Items.Count - 1)
			{
				AccordionItem item = AccordianWizard.Items[AccordianWizard.SelectedIndex + 1] as AccordionItem;
				item.IsSelected = true;
			}
		}
		void ComboboxVendor_Loaded(object sender, RoutedEventArgs e)
		{
			if (vendorDeviceList.Count > 0)
			{
				((ComboBox)sender).ItemsSource = vendorDeviceList;
				((ComboBox)sender).SelectedIndex = 0;
			}			
		}
		void ComboboxType_Loaded(object sender, RoutedEventArgs e)
		{
			((ComboBox)sender).Items.Add(new KeyValuePair<string, string>("V", "Voltage"));
			((ComboBox)sender).Items.Add(new KeyValuePair<string, string>("I", "Current"));
			((ComboBox)sender).SelectedIndex = 0;
		}
		void ComboboxPhase_Loaded(object sender, RoutedEventArgs e)
		{
			((ComboBox)sender).Items.Add(new KeyValuePair<string, string>("+", "Positive"));
			((ComboBox)sender).Items.Add(new KeyValuePair<string, string>("-", "Negative"));
			((ComboBox)sender).Items.Add(new KeyValuePair<string, string>("A", "Phase A"));
			((ComboBox)sender).Items.Add(new KeyValuePair<string, string>("B", "Phase B"));
			((ComboBox)sender).Items.Add(new KeyValuePair<string, string>("C", "Phase C"));
			((ComboBox)sender).SelectedIndex = 0;
		}
		
		#endregion

		//void UploadIniFile(string fileName, Stream fileData)
		//{
		//    string hostUrl = HtmlPage.Document.DocumentUri.AbsoluteUri;
		//    hostUrl = hostUrl.Substring(0, hostUrl.IndexOf("#"));
		//    hostUrl = hostUrl.Substring(0, hostUrl.LastIndexOf("/"));

		//    string handlerUrl = hostUrl + "/HttpHandlers/IniFileUploader.ashx";

		//    UriBuilder uriBuilder = new UriBuilder(handlerUrl);
		//    uriBuilder.Query = string.Format("fileName={0}", iniFileName);

		//    WebClient webClient = new WebClient();
		//    webClient.OpenWriteCompleted += (sender, e) =>
		//        {
		//            PushFileData(fileData, e.Result);
		//            e.Result.Close();
		//            fileData.Close();
		//        };
		//    webClient.OpenWriteAsync(uriBuilder.Uri);						
		//}
		//void PushFileData(Stream input, Stream output)
		//{
		//    byte[] buffer = new byte[4096];
		//    int bytesRead;
		//    while ((bytesRead = input.Read(buffer, 0, buffer.Length)) != 0)
		//    {
		//        output.Write(buffer, 0, bytesRead);
		//    }
		//}
		void InputWizard_Loaded(object sender, RoutedEventArgs e)
		{
			
		}
		void PdcInfoVisualization(Visibility visibility)
		{
			TextBlockPDCName.Visibility = visibility;
			TextBoxPDCName.Visibility = visibility;
			TextBlockAcronym.Visibility = visibility;
			TextBoxPDCAcronym.Visibility = visibility;
			TextBlockPDCDeviceVendor.Visibility = visibility;
			ComboboxPDCVendor.Visibility = visibility;
		}
		void IniFileUploadVisualization(Visibility visibility)
		{
			TextBlockIniFile.Visibility = visibility;
			StackPanelIniFile.Visibility = visibility;
		}		
		byte[] ReadFileBytes(Stream inputStream)
		{
			byte[] bytes;
			//using (FileStream fileStream = file.OpenRead())
			//{
				// Read the source file into a byte array.
			bytes = new byte[inputStream.Length];
			int numBytesToRead = (int)inputStream.Length;
			int numBytesRead = 0;
			while (numBytesToRead > 0)
			{
				// Read may return anything from 0 to numBytesToRead.
				int n = inputStream.Read(bytes, numBytesRead, numBytesToRead);

				// Break when the end of the file is reached.
				if (n == 0)
					break;

				numBytesRead += n;
				numBytesToRead -= n;
			}
			numBytesToRead = bytes.Length;
			//}
			return bytes;
		}
		T Deserialize<T>(Stream inputStream)
		{
			var serializer = new DataContractSerializer(typeof(T));
			T deserializedObject = (T)serializer.ReadObject(inputStream);
			return deserializedObject;
		}
		
		// Executes when the user navigates to this page.
		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			wizardDeviceInfoList = new ObservableCollection<WizardDeviceInfo>();
			vendorDeviceList = new Dictionary<int, string>();
			client.GetProtocolsAsync(false);
			client.GetVendorDevicesAsync(true);
			PdcInfoVisualization(Visibility.Collapsed);
			if (AccordianWizard.SelectedIndex == 0)
				ButtonPrevious.Visibility = Visibility.Collapsed;
			client.GetCompaniesAsync(true);
			client.GetHistoriansAsync(true, true);
			client.GetInterconnectionsAsync(true);
			client.GetExecutingAssemblyPathAsync();
		}
	}
}
