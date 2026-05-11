# RAW Demo
A basic image viewer using our RawDecoder to load/view RAW format images (DNG, RAW, CR2, etc...) as well as the embedded thumbnails and image info.  

Demonstrates using our RawDecoder to view and scale RAW format images, as well as accessing the embedded thumbnail, preview, and Image Info.  

In addition, our RawDecoder allows for control over loading policy, interpolation, white balance and Image metrics. This demo provides a practical working example of these settings.

This is the VB.NET version. We also have a [C# version](https://github.(mailto:sales@atalasoft.com)/AtalaSupport/DemoGallery_Desktop_RawDemo_CS_x64) available.

## Raw Support / Libraries
Atalasoft's RawDecoder used to use DCRaw, and still includes it for backward compatibility. However that library has not been updated in some time. We've switched our default to LibRaw (currently 0.22.0). However we also offer the ability to configure for external LibRaw so you can "bring your own" should you need a newer version than we include.

### Configuring which Library to use for RAW
Under the hood it can be configured with 3 options
- DCRaw (uses dcraw-static-9.28 - for backward compatibility - [DCRaw](https://dechifro.org/dcraw/) has not been updated since 2018)
- LibRaw (DotImage 2026 includes [libraw-0.22.0](https://www.libraw.org/news/libraw-0-22-0-release))
- LibRaw external (bring your own)


#### Configuring in Web.Config
For a web app, you would configure the RawDecoder in web.config
```xml
<configSections>
    <section name="Atalasoft" type="Atalasoft.Shared.AtalasoftConfigSection, Atalasoft.Shared"/>
</configSections>

<Atalasoft>
    <RawDecoder LibRawLocation="C:\Folder\Subfolder\SubSubFolder" UserDefinedLibRaw="true" NativeLibValidationType="CheckSum" RenderingEngine="LibRaw" />
</Atalasoft>

<connectionStrings />
```


#### Configuring in App.Config
For desktop apps in .NET Framework, you configure in app.config

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <configSections>
        <section name="Atalasoft" type="Atalasoft.Shared.AtalasoftConfigSection, Atalasoft.Shared" />
    </configSections>

    <Atalasoft>
        <RawDecoder LibRawLocation="C:\Folder\Subfolder\SubSubFolder" UserDefinedLibRaw="true" NativeLibValidationType="CheckSum" RenderingEngine="LibRaw" />
    </Atalasoft>
</configuration>
```


## Licensing
This application requires a license for DotImage Photo Pro or DotImage Document Imaging. You may request a 30 day evaulation if youre evaluating if DotImage / our OCR is right for you.


## SDK Dependencies
This app was built based on 2026.2.0.0. It targets .NET Framework 4.6.2 and was created in Visual Studio 2022. You must have our SDK installed (and licesed per above)

[Download DotImage](https://www.atalasoft.(mailto:sales@atalasoft.com)/BeginDownload/DotImageDownloadPage)


### Using NuGet for SDK Dependencies
We do publish our SDK components to NuGet. We have chosen to base the demo on local installed SDK because this leads to much smaller applications (NuGet packages add a lot of overhead due to the way they're packaged and deployed, and many of our demos -- including this one -- are often used to reproduce issues that need to be submitted to support. Apps that use NuGet are often significantly larger and run up against our maximum support case upload size)

Still, if you wish to use NuGet for the dependencies instead of relying on locally installed SDK, you can.

- Take note of each of the references we've included:
    - Atalasoft.DotImage.dll
    - Atalasoft.DotImage.Lib.dll
    - Atalasoft.DotImage.PdfDoc.Bridge.dll
    - Atalasoft.DotImage.Raw.dll
    - Atalasoft.DotImage.WinControls.dll
    - Atalasoft.PdfDoc.dll
    - Atalasoft.Shared.dll
- Remove those referneces
- Open the NuGet Package Manger from `Tools -> NuGet Package Manager -> Manage NuGet Packages for this Solution`
- Browse for and install  Atalasoft.DotImage.WinControls.x64 - It will pull in DotImage Document Imaging (the base SDK) and our windows controls and shared dll
- Browse for and install Atalasoft.Raw.x64  - this will bring in the RawDecoder features


## Downloading source
The sources can be downloaded for [c#](https://github.(mailto:sales@atalasoft.com)/AtalaSupport/DemoGallery_Desktop_RawDemo_CS_x64/archive/refs/heads/main.zip) and [VB.NET](https://github.(mailto:sales@atalasoft.com)/AtalaSupport/DemoGallery_Desktop_RawDemo_VB_x64/archive/refs/heads/main.zip)


## Cloning
If you wish to clone the repo, we recommend:

Example: git for windows
```bash
git clone https://github.(mailto:sales@atalasoft.com)/AtalaSupport/DemoGallery_Desktop_RawDemo_VB_x64.git RawDemo
```


## Related documentation
In addition to this README, the Atalasoft documentation set includes the following:  
- [AtalaSupport Github](https://github.(mailto:sales@atalasoft.com)/AtalaSupport/) For an extensive set of sample apps.  
- [Atalasoft's APIs & Developer Guides page](https://www.atalasoft.(mailto:sales@atalasoft.com)/Support/APIs-Dev-Guides) for our Developers guide and API references.  
- [Atalasoft Support](http://www.atalasoft.(mailto:sales@atalasoft.com)/support/) for our main support portal.
- [Atalasoft Knowledgebase](http://www.atalasoft.(mailto:sales@atalasoft.com)/kb2) where you can find answers to common questions / issues.  


## Getting Help for Atalasoft products
Atalasoft regularly updates our support [Knowledgebase](http://www.atalasoft.(mailto:sales@atalasoft.com)/kb2) with the latest information about our products. To access some resources, you must have a valid Support Agreement with an authorized Atalasoft Reseller/Partner or with Atalasoft directly. Use the tools that Atalasoft provides for researching and identifying issues. 

Customers with an active evaluation, or those with active support / maintenance may [create a support case](https://www.atalasoft.(mailto:sales@atalasoft.com)/Support/my-portal/Cases/Create-Case) 24/7, or call in to support ([+1 949 236-6510](tel:19492366510) ) during our normal support hours (Monday - Friday 8:00am to 5:00PM Eastern (New York) time).  

Customers who are unable to create a case or call in may [email our Sales Team](mailto:sales@atalasoft.com).  


           