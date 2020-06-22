<%@ Page Title="Free online document converter for DOC, DOCX, PDF, XLSX, PPTX, EML and other formats" MetaDescription="Convert document to any format, ODS, XLS, XLSX, XLSM, XLSB, CSV, XLS2003, XLTX, XLTM, TIFF, TIF, JPEG, JPG, PNG, GIF, BMP, ICO, PSD, SVG, WEBP, JP2, PDF, EPUB, XPS, PPT, PPS, PPTX, PPSX, ODP, OTP, POTX, POTM, PPTM, PPSM, DOC, DOCM, DOCX, DOT, DOTM, DOTX, RTF, TXT, ODT, OTT, HTML" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" EnableEventValidation="true" CodeBehind="Default.aspx.cs" Inherits="GroupDocs.Conversion.Live.Demos.UI.Default" %>

<asp:Content ID="HeadContents1" ContentPlaceHolderID="HeadContents" runat="server">

	<meta charset="UTF-8">
	<meta content="width=device-width, initial-scale=1.0" name="viewport" />
	<meta name="author" content="groupdocs.app" />
	<meta name="keywords" content="<%=metakeywords %>" />
	<link rel="canonical" href="https://products.groupdocs.app/conversion/total" />
	<link rel="icon" type="image/png" sizes="16x16" href="https://products.groupdocs.app/images/groupdocs1616.png">
	<meta property="og:site_name" content="GroupDocs.App | Free Online <%=fileFormat  %>Converter" />
	<meta property="og:title" content="<%=metatitle %>" />
	<meta property="og:description" content="<%=metadescription %>" />
	<meta property="og:image" content="https://products.groupdocs.app/images/groupdocsapp.png" />
	<meta property="og:type" content="website" />
	<meta property="og:url" content="https://products.groupdocs.app/conversion/total" />
	<meta name="twitter:card" content="summary_large_image">
	<meta name="twitter:site" content="@groupdocsapp">
	<meta name="twitter:creator" content="@groupdocsapp">
	<meta name="twitter:title" content="<%=metatitle %>">
	<meta name="twitter:description" content="<%=metadescription %>">
	<meta name="twitter:image:src" content="https://products.groupdocs.app/images/groupdocsapp.png" />
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<div class="modal fade" style="padding-top: 10%;" id="customerrorModalSuccess" tabindex="-1" role="dialog" aria-labelledby="customerrorModalLabel">
		<div class="modal-dialog" role="document">
			<div class="modal-content">
				<div class="modal-content">
					<div class="modal-header">
						<button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
						<h4 class="modal-title" style="color: green;" id="customerrorModalSuccessLabel">Error has been reported successfully.</h4>
						<p id="p1" runat="server"></p>
					</div>
					<div class="modal-body">
						<p><b><i>You have successfully reported the error, You will get the notification email when error is fixed, <span id="lnkForums" runat="server"></span>to visit the forums.</i></b></p>
					</div>
					<div class="modal-footer">
						<button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
					</div>
				</div>
			</div>
		</div>
	</div>
	<div class="modal fade" style="padding-top: 10%;" id="customerrorModal" tabindex="-1" role="dialog" aria-labelledby="customerrorModalLabel">
		<div class="modal-dialog" role="document">
			<div class="modal-content">
				<div class="modal-header">
					<button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
					<h4 class="modal-title" style="color: red;" id="customerrorModalLabel">Oops! An error has occured.</h4>
					<p id="pPopupMessage" runat="server"></p>
				</div>
				<div class="modal-body">
					<p id="pPopupBody" runat="server"></p>
					<div class="form-group">
						<label for="recipient-name" class="control-label">Email:</label><asp:RequiredFieldValidator runat="server" ForeColor="Red" ID="rfvErrorEmail" ControlToValidate="txtuserEmail" ErrorMessage="please enter email address." ValidationGroup="vgErrorReport"></asp:RequiredFieldValidator>
						<asp:TextBox CssClass="form-control" placeholder="email address" ID="txtuserEmail" runat="server"></asp:TextBox>
						<asp:RegularExpressionValidator ID="regexEmailValid" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtuserEmail" ValidationGroup="vgErrorReport" ForeColor="Red" ErrorMessage="Invalid Email Format"></asp:RegularExpressionValidator>
					</div>
					<div class="form-group">
						<input type="checkbox" id="chkErrorPrivate" runat="server" checked="checked" title="Make this forum private, so that it will only be accessable to you and our developers." />&nbsp;Make this forum private, so that it will only be accessable to you and our developers.
									<input type="hidden" id="hdErrorMessage" runat="server">
						<input type="hidden" id="hdErrorDetail" runat="server">
						<input type="hidden" id="hdErrorFolder" runat="server">
					</div>
				</div>
				<div class="modal-footer">
					<button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
					<asp:Button CssClass="btn btn-primary" ID="btnReport" runat="server" OnClick="btnReport_Click" ValidationGroup="vgErrorReport" Text="Report Error" />
				</div>
			</div>
		</div>
	</div>
	<asp:UpdatePanel ID="UpdatePanel1" runat="server">
		<ContentTemplate>
			<div class="container-fluid GroupDocsApps">
				<div class="container">
					<div class="row">
						<div class="col-md-12 pt-5 pb-5">
							<h1 id="hheading" runat="server">Free Online Document Converter</h1>
							<h2 style="font-size: 22px !important; color: #fff !important;" id="hdescription" runat="server">Convert your Word, PDF, PowerPoint, Excel and more than 50 types of documents & images, 100% free online!</h2>
							<input type="hidden" id="hfIsToFormat" value="0" runat="server" />
							<div class="form">
								<asp:PlaceHolder ID="ConvertPlaceHolder" runat="server">
									<div class="uploadfile">
										<div class="filedropdown">
											<div class="filedrop">
												<label class="dz-message needsclick"><% =DropOrUploadFileText %></label>
												<asp:FileUpload Name="UploadFile" ID="UploadFile" runat="server" CssClass="uploadfileinput" />
												<asp:RegularExpressionValidator ID="ValidateFileType" ValidationExpression="([a-zA-Z0-9\s)\s(\s_\\.\-:])+(.doc|.docx|.dot|.dotx|.rtf)$"
													ControlToValidate="UploadFile" runat="server" ForeColor="Red"
													Display="Dynamic" />
												<asp:HiddenField ID="hdnFileExtensionMessage" runat="server" />
												<div class="fileupload">
													<span class="filename">
														<a href="#">
															<label for="uploadfileinput" id="lblFilename" class="custom-file-upload"></label>
														</a>
													</span>
												</div>
											</div>
											<p runat="server" id="pMessage"></p>
											<div class="saveas">
												<em>Save as</em>
												<div class="btn-group">
													<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
													<link href="https://cdnjs.cloudflare.com/ajax/libs/select2/4.0.0/css/select2.min.css" rel="stylesheet" type="text/css" />
													<script src="https://cdnjs.cloudflare.com/ajax/libs/select2/4.0.0/js/select2.full.min.js"></script>
													<select name="ddlTo" id="ddlTo" class="select2" onchange="UpdateFormat()">
														<option value="*">Select File</option>
													</select>
													<asp:HiddenField ID="hfToFormat" Value="~" runat="server" />
												</div>
											</div>
											<div class="convertbtn">
												<asp:Button runat="server" ID="btnConvert" class="btn btn-success btn-lg" Text="CONVERT NOW" OnClick="btnConvert_Click" />
											</div>
											<asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
												<ProgressTemplate>
													<div>
														<img height="59px" width="59px" alt="Please wait..." src="../../img/loader.gif" />
													</div>
												</ProgressTemplate>
											</asp:UpdateProgress>
										</div>
									</div>
								</asp:PlaceHolder>
								<asp:PlaceHolder ID="DownloadPlaceHolder" runat="server" Visible="false">
									<div class="filesendemail">

										<div class="filesuccess">
											<label class="dz-message needsclick"><%=Resources["FileConvertedSuccessMessage1"]%></label>
											<span class="downloadbtn convertbtn">
												<asp:Literal ID="litDownloadNow" runat="server"></asp:Literal>
											</span>
											<div class="clearfix">&nbsp;</div>
											<a href="" class="btn btn-link refresh-c"><%=Resources["ConvertAnotherFile"]%> <i class="fa-refresh fa "></i></a>
											<a class="btn btn-link" target="_blank" href="https://products.groupdocs.cloud/conversion/family">Cloud API &nbsp;<i class="fa-cloud fa"></i></a>
										</div>

										<p><%=Resources["SendTo"]%> </p>
										<div class="col-5 sendemail">
											<div class="input-group input-group-lg">
												<input type="email" id="emailTo" name="emailTo" class="form-control" placeholder="email@domain.com" runat="server" />
												<input type="hidden" id="downloadUrl" name="downloadUrl" runat="server" />
												<span class="input-group-btn">
													<asp:LinkButton class="btn btn-success" type="button" ID="btnSend" runat="server" OnClick="btnSend_Click" Text="<i class='fa fa-envelope-o fa'></i>" />
												</span>
											</div>
										</div>
										<br />
										<asp:UpdateProgress ID="UpdateProgress2" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
											<ProgressTemplate>
												<div>
													<img height="59px" width="59px" alt="Please wait..." src="../../img/loader.gif" />
												</div>
											</ProgressTemplate>
										</asp:UpdateProgress>
										<p runat="server" id="pMessage2"></p>
									</div>
								</asp:PlaceHolder>
							</div>
						</div>
					</div>
				</div>
			</div>

			<div class="col-md-12 pt-5 app-features-section" style="padding-top: 0px!important; padding-bottom: 0px!important; background-color: #277ce43b;">
				<div class="container tc pt-5">
					<div class="col-lg-12">
						<h3>Explore More Free Apps!</h3>
						<br />
						<em>Free Online Apps to View, Convert, Assemble, Watermark, Compare and Search data from Microsoft Office, Visio, Project, OpenOffice, AutoCAD, PDL, 3D & Images.</em>
					</div>
					<div class="col-lg-12 pf-urls"><a class="cloudbg btn " href="https://products.groupdocs.app/viewer/total">Free Online Viewer</a> <a class="cloudbg btn " href="https://products.groupdocs.app/metadata/total">Free Online Metadata Editor</a> <a class="cloudbg btn " href="https://products.groupdocs.app/comparison/total">Free Online Comparison</a> <a class="cloudbg btn " href="https://products.groupdocs.app/editor/total">Free Online Eiditor</a> <a class="cloudbg btn " href="https://products.groupdocs.app/merger/total">Free Online Merger</a> <a class="cloudbg btn " href="https://products.groupdocs.app">More Apps...</a></div>
				</div>
			</div>

			<div class="col-md-12 pt-5 bg-gray tc" style="padding-bottom: 0px!important;" id="dvAllFormats" runat="server">
				<div class="container">
					<div class="col-md-12 pull-left">
						<h2 class="h2title">GroupDocs.Conversion App</h2>
						<p>GroupDocs.Conversion App Supported Output Document Formats</p>
						<div class="diagram1 d2 d1-net">
							<div class="d1-row">
								<div class="d1-col d1-left">
									<header>Convert From:</header>
									<ul>
										<li><strong>Documents:</strong> DOC, DOCX, DOCM, DOT, DOTX, DOTM, RTF, TXT, ODT, OTT</li>
										<li><strong>Spreadsheets:</strong> XLS, XLSX, XLSM, XLSB, CSV, XLS2003, ODS, TSV, XLT, XLTX, XLTM</li>
										<li><strong>Presentations:</strong> PPT, PPTX, PPS, PPSX, ODP, POT, POTX, POTM, PPTM, PPSM</li>
										<li><strong>Images:</strong> TIF, TIFF, JPG, JPEG, PNG, GIF, BMP, ICO, DIB</li>
										<li><strong>Portable:</strong> PDF, XPS</li>
										<li><strong>HTML:</strong> HTM, HTML, MHT</li>
										<li><strong>PhotoShop:</strong> PSD</li>
										<li><strong>Tasks</strong> MPT, MPP</li>
										<li><strong>Email:</strong> MSG, EML, EMLX</li>
										<li><strong>Diagrams:</strong> VSD, VSDX, VSS, VST, VSX, VTX, VDW, VDX, SVG</li>
										<li><strong>AutoCAD:</strong> DXF, DWG, STL, IFC</li>
										<li><strong>Metafiles:</strong> EMF, WMF</li>
										<li><strong>CorelDRAW:</strong> CDR, CMX</li>
										<li><strong>Other:</strong> VCF</li>
									</ul>
								</div>
								<!--/left-->
								<div class="d1-col d1-right">
									<header>Convert To:</header>
									<ul>
										<li><strong>Documents:</strong> DOC, DOCX, DOCM, DOT, DOTX, DOTM, RTF, TXT, ODT, OTT</li>
										<li><strong>Spreadsheets:</strong> XLS, XLSX, XLSM, XLSB, CSV, XLS2003, ODS</li>
										<li><strong>Presentations:</strong> PPT, PPTX, PPS, PPSX, ODP</li>
										<li><strong>Images:</strong> TIF, TIFF, JPG, JPEG, PNG, GIF, BMP, ICO</li>
										<li><strong>Portable:</strong> PDF, XPS</li>
										<li><strong>HTML:</strong> HTM, HTML, MHT</li>
									</ul>
								</div>
								<!--/right-->
							</div>
							<!--/row-->
							<div class="d1-logo">
								<img src="https://www.groupdocs.cloud/templates/groupdocs/images/product-logos/90x90-noborder/groupdocs-conversion-net.png" alt=".NET Files Conversion API"><header>GroupDocs.Conversion</header>
								<footer><small>App</small></footer>
							</div>
							<!--/logo-->
						</div>
					</div>
				</div>
			</div>

			<div class="col-md-12 pull-left d-flex d-wrap bg-gray appfeaturesectionlist" id="dvFormatSection" runat="server" visible="false">
				<div class="col-md-4 cardbox tc col-md-offset-2">
					<h3 runat="server" id="hExtension1"></h3>
					<p runat="server" id="hExtension1Description1"></p>
				</div>
				<div class="col-md-4 tc cardbox" id="dvFormatDesc2" runat="server">
					<h3 runat="server" id="hExtension2"></h3>
					<p runat="server" id="hExtension1Description2"></p>
				</div>
			</div>

			<!-- HowTo Section -->
			<div class="col-md-12 tl bg-darkgray howtolist">
				<div class="container tl dflex">

					<div class="col-md-4 howtosectiongfx">
						<img src="/img/howto.png">
					</div>
					<div class="howtosection col-md-8">
						<div>
							<h2><i class="fa fa-question-circle "></i>&nbsp;<b>How to convert<%=howto %></b></h2>
							<ul>
								<li>Click inside the file drop area to upload <%=fileFormat  %>files or drag & drop a <%=fileFormat  %>file.</li>
								<li>Your <%=fileFormat  %>files will be uploaded and will be converted to <%=fileFormat2  %>format.</li>
								<li>File will be automatically rendered for you to convert instantly.</li>
								<li>You can also send a link to the <%=fileFormat2  %>file to your email address.</li>
								<li>Note that file will be deleted from our servers after 24 hours and download links will stop working after this time period.</li>
							</ul>
						</div>
					</div>
				</div>
			</div>


			<div class="col-md-12 pt-5 app-features-section" style="padding-bottom: 0px!important;">
				<div class="container tc pt-5">
					<div class="col-md-4">
						<div class="imgcircle fasteasy">
							<img src="../../img/fast-easy.png" />
						</div>
						<h4><%= Resources["Feature1"] %></h4>
						<p><%= Resources["Feature1Description"] %></p>
					</div>

					<div class="col-md-4">
						<div class="imgcircle anywhere">
							<img src="../../img/anywhere.png" />
						</div>
						<h4><%= Resources["Feature2"] %></h4>
						<p><%= Resources["Feature2Description"] %></p>
					</div>

					<div class="col-md-4">
						<div class="imgcircle quality">
							<img src="../../img/quality.png" />
						</div>
						<h4><%= Resources["Feature3"] %></h4>
						<p><%= Resources["PoweredBy"] %> <a runat="server" target="_blank" id="aPoweredBy"></a><%= Resources["QualityDescMetadata"] %></p>
					</div>
				</div>
			</div>			
			<script type="text/javascript">
				window.onsubmit = function () {
					if (Page_IsValid) {

						var updateProgress = $find("<%= UpdateProgress1.ClientID %>");
						if (updateProgress) {
							window.setTimeout(function () {
								updateProgress.set_visible(true);
								document.getElementById('<%= pMessage.ClientID %>').style.display = 'none';
							}, 100);
						}

						var updateProgress2 = $find("<%= UpdateProgress2.ClientID %>");
						if (updateProgress2) {
							window.setTimeout(function () {
								updateProgress2.set_visible(true);
								document.getElementById('<%= pMessage2.ClientID %>').style.display = 'none';
							}, 100);
						}
					}
				}
			</script>
			<style>
				.select2-container--default .select2-selection--single {
					background: #ebebeb !important;
					border: none !important;
					border-radius: 0px !important;
				}

				.select2-selection__arrow {
					height: 50px !important;
					top: 3px !important;
					right: 8px !important;
				}

				.select2 {
					background: #ebebeb !important;
					border: 1px solid #CCCCCC !important;
					padding: 15px !important;
					font-size: 18px !important;
					color: #757 75 ! mportant;
					rder-radiu: 4px !important;
					text-align: lft imprtan;
					min-width: ! nt;
					box-shadow: 0 6px 1px -5px #666666 !important;
				}
			</style>

			<script>
				function UpdateFormat() {
					//alert('Selected Value: ' + document.getElementById('ddlTo').value);
					document.getElementById('<%= hfToFormat.ClientID %>').value = document.getElementById('ddlTo').value;
					//alert('Selected hfToFormat Value: ' + document.getElementById('<%= hfToFormat.ClientID %>').value);
				}

                function GetFormats(strFromFormat) {
                    console.log(document.getElementById('<%= hfIsToFormat.ClientID %>'));
					if (document.getElementById('<%= hfIsToFormat.ClientID %>') != null) {
						console.log("!undefined: " + document.getElementById('<%= hfIsToFormat.ClientID %>').value);
						if (document.getElementById('<%= hfIsToFormat.ClientID %>').value == "0") {
							console.log("AJAX");
							$.ajax({
								type: "get",
								url: "api/GroupDocsConversion/GetToSupportedFormats?toFormat=" + strFromFormat,
								contentType: "application/json; charset=utf-8",
								dataType: "json",
								success: function (result) {
									OnSuccess(result.OutputType);
								},
								error: function (xhr, status, error) {
									OnFailure(error);
								}
							});
						}
						else {
							if (document.getElementById('<%= hfToFormat.ClientID %>') != undefined) {
								if (document.getElementById('<%= hfToFormat.ClientID %>').value != "~") {
									var ddl = document.getElementById('ddlTo');
									ddl.options.length = 0;
									var option = document.createElement("OPTION");
									option.innerHTML = document.getElementById('<%= hfToFormat.ClientID %>').value.toUpperCase();
									option.value = document.getElementById('<%= hfToFormat.ClientID %>').value.toLowerCase();
									ddl.options.add(option);
									UpdateFormat();
								}
							}
						}
					}
				}

				function OnSuccess(toFormats) {
					var str_array = toFormats.replace(" ", "").split(',');
					var ddl = document.getElementById('ddlTo');
					ddl.options.length = 0;
					for (var i = 0; i < str_array.length; i++) {
						var option = document.createElement("OPTION");
						option.innerHTML = str_array[i].replace(" ", "");
						option.value = str_array[i].replace(" ", "").toLowerCase();
						ddl.options.add(option);
						if (document.getElementById('<%= hfToFormat.ClientID %>').value == str_array[i].replace(" ", "").toLowerCase()) {
							ddl.options[i].selected = true;
						}
					}
					UpdateFormat();
					if (ddl.options.length > 1) {
						$(function () {
							$("select").select2();
						});
					}
					//alert(toFormats);
				}

				function OnFailure(error) {
					var ddl = document.getElementById('ddlTo');
					ddl.options.length = 0;
					var option = document.createElement("OPTION");
					option.innerHTML = strFromFormat;
					option.value = strFromFormat.toLowerCase();
					ddl.options.add(option);
					UpdateFormat();
					alert(error);
				}

				$(document).ready(function () {
					bindEvents();
					if (document.getElementById('<%= hfToFormat.ClientID %>') != undefined) {
						if (document.getElementById('<%= hfToFormat.ClientID %>').value != "~") {
							GetFormats(document.getElementById('<%= hfToFormat.ClientID %>').value);
						}
					}
				});

				Sys.WebForms.PageRequestManager.getInstance().add_endRequest(function (evt, args) {
					bindEvents();
				});

				function readableFileSize(size) {
					if (size <= 0) return "0";
					var units = ["B", "KB", "MB", "GB", "TB"];
					var digitGroups = Math.floor(Math.log10(size) / Math.log10(1024));
					return Math.floor((size / Math.pow(1024, digitGroups))) + " " + units[digitGroups];
				}

				function bindEvents() {
					$('.fileupload').hide();
					$('#<%= UploadFile.ClientID %>').change(function () {
						$('.fileupload').hide();
						var files = document.getElementById('<%= UploadFile.ClientID %>').files;
						var fileextension = files[0].name.split('.')[files[0].name.split('.').length - 1];
						var filenames = "";
						document.getElementById('<%= pMessage.ClientID %>').style.display = 'none';
						for (var i = 0; i < files.length; i++) {
							filenames += files[i].name + " (" + readableFileSize(files[i].size) + ") , ";
							if (fileextension != files[i].name.split('.')[files[i].name.split('.').length - 1]) {
								document.getElementById('<%= pMessage.ClientID %>').style.display = 'block';
								document.getElementById('<%= pMessage.ClientID %>').value = 'invalid file extention.';
							}
						}

						$('#lblFilename').text(filenames);
						$('.fileupload').show();

						GetFormats(fileextension);
					});

					if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {

						var swiper = new Swiper('.swiper-container', {
							slidesPerView: 5,
							spaceBetween: 20,
							// init: false,
							pagination: {
								el: '.swiper-pagination',
								clickable: true,
							},
							navigation: {
								nextEl: '.swiper-button-next',
								prevEl: '.swiper-button-prev',
							},
							breakpoints: {
								868: {
									slidesPerView: 4,
									spaceBetween: 20,
								},
								668: {
									slidesPerView: 2,
									spaceBetween: 0,
								}
							}
						});
					}
				}
			</script>
		</ContentTemplate>
		<Triggers>
			<asp:PostBackTrigger ControlID="btnConvert" />
			<asp:PostBackTrigger ControlID="btnReport" />
			<asp:PostBackTrigger ControlID="btnSend" />
		</Triggers>
	</asp:UpdatePanel>
	<script>
		$(document).ready(function ($) {
			//$('#customerrorModalSuccess').modal('show');
		});
	</script>
</asp:Content>
