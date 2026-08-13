# WPF DatePicker Samples

This repository contains a collection of WPF samples that demonstrate different customization and interaction scenarios using the **Syncfusion SfDatePicker** and related selector controls. Each sample focuses on a specific feature or behavior to help developers understand how to extend and customize the DatePicker experience.

## Overview
The samples included in this repository show how the SfDatePicker control can be configured and customized to improve usability, appearance, and user interaction. The scenarios cover keyboard navigation, resizing selector elements, and styling selector items using templates.

These examples are useful for applications that require a highly customizable date selection interface while maintaining a clean and responsive user experience.

## What This Repository Demonstrates
- How to change date values using keyboard navigation
- How to control the size of date selector elements dynamically
- How to customize the appearance of looping selector items
- How to work with SfDatePicker templates and internal elements
- How to enhance DatePicker usability through customization

## Included Samples
- **Arrow Key Navigation**  
  Demonstrates how to change the selected date using the Up and Down arrow keys by setting focus to the internal date selector when the drop‑down opens.

- **Selector Size Customization**  
  Shows how to adjust the height of the DateSelector dynamically based on the window size.

- **Template Customization**  
  Illustrates how to customize the background and foreground of looping selector items using styles and templates.

## Key Controls Used
- **SfDatePicker**: Provides date selection with rich customization support
- **SfDateSelector**: Displays date values using looping selectors
- **LoopingSelector / LoopingSelectorItem**: Enables scrolling date selection
- **Popup**: Hosts the date selector drop‑down
- **Styles and Templates**: Control the visual appearance of selector items

## How It Works
1. SfDatePicker is placed in a WPF window.
2. Internal elements such as the date selector and popup are accessed when required.
3. Keyboard focus and size adjustments are applied programmatically.
4. Styles are defined to customize looping selector visuals.
5. The DatePicker reflects these customizations at runtime.

## Benefits
- Enhances keyboard accessibility for date selection
- Provides flexible control over selector size and layout
- Allows deep visual customization of date selector items
- Improves user experience for date‑driven applications
- Demonstrates advanced customization techniques for SfDatePicker

These samples are ideal references for developers who want to customize the behavior and appearance of the Syncfusion WPF DatePicker control in real‑world applications.

1. [How to change the date using up or down navigation keys in WPF DatePicker (SfDatePicker)?](https://www.syncfusion.com/kb/9345/how-to-change-the-date-using-up-down-navigation-keys-in-sfdatepicker) - [Demo](https://github.com/SyncfusionExamples/WPF-DatePicker-Samples/tree/main/SfDatePicker_ArrowKeySample)
2. [How to display more looping items in the DateSelector and TimeSelector?](https://www.syncfusion.com/kb/8758/how-to-display-more-looping-items-in-the-dateselector-and-timeselector) - [Demo](https://github.com/SyncfusionExamples/WPF-DatePicker-Samples/tree/main/SfDatePicker_SelectorSize)
3. [How to change the background color for LoopingSelectorItem in WPF DatePicker (SfDatePicker)?](https://www.syncfusion.com/kb/8228/how-to-change-the-background-color-for-loopingselectoritem-in-sfdatepicker) - [Demo](https://github.com/SyncfusionExamples/WPF-DatePicker-Samples/tree/main/SfDatePicker_Template)

## Requirements to run the sample

Refer to the following link for more details - [System Requirements](https://help.syncfusion.com/wpf/system-requirements)

## How to run the sample

1. Clone the sample and open it in Visual Studio.

   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*

2. Register your license key in the Program.cs file as demonstrated in the following code.

    public partial class App : Application
    {
      //Register Syncfusion license
			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
    }
		
	Refer to this [link](https://help.syncfusion.com/wpf/licensing/overview) for more details.

3. Clean and build the application.

4. Run the application.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples. 
