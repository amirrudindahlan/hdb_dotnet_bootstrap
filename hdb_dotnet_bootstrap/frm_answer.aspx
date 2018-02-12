<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_answer.aspx.cs" Inherits="hdb_dotnet_bootstrap.frm_answer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta name="description" content=""/>
    <meta name="author" content="Srikanth"/>
    <title>HDBSENSEMAKE - Findings</title>
    <!-- Bootstrap Core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
    <!-- Custom CSS -->
    <link href="css/the-big-picture.css" rel="stylesheet"/>
    <link href="css/font-icon.css" rel="stylesheet" type="text/css" />
    <link href="css/jquery.fancybox.css" rel="stylesheet" type="text/css" />
    <link href="css/flexslider.css" rel="stylesheet" type="text/css" />
    <link href="css/main.css" rel="stylesheet" type="text/css" />
    <link href="css/responsive.css" rel="stylesheet" type="text/css" />
    <link href="css/animate.min.css" rel="stylesheet" type="text/css" />
    <!-- ============ Google fonts ============ -->
    <link href='http://fonts.googleapis.com/css?family=EB+Garamond' rel='stylesheet'
        type='text/css' />
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:400,600,700,300,800'
        rel='stylesheet' type='text/css' />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css"/>
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body id="hme">
    <form id="form1" runat="server">


    <!-- Section: top nav -->

    <div id="custom-bootstrap-menu" class="navbar navbar-default " role="navigation">
        <div class="container">
            <div class="navbar-header">
                <a class="navbar-brand" href="#">HDBSenseMake</a>
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-menubuilder">
                    <span class="sr-only">Toggle navigation</span><span class="icon-bar"></span><span
                        class="icon-bar"></span><span class="icon-bar"></span>
                </button>
            </div>
            <div class="collapse navbar-collapse navbar-menubuilder">
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="frm_search.aspx">Submit A New Concern</a> </li>
                    <li><a href="#concerns">Ground Concerns</a> </li>
                    <li><a href="#analytics">Visual Analytics</a> </li>
                    <li><a href="#article">Relevent Articles</a> </li>
                </ul>
            </div>
        </div>
    </div>




    <!-- Section: answer -->
    <section id="contact" class="home-section text-center">
        <h2>Here's our findings</h2>
    <div class="container">
    <div class="row">
        <div class="col-lg-8 col-md-offset-2">
            <div class="form-wrapper marginbot-50">
                <div class="row">
    
                        <div class="form-group">

                            <section id="concerns"></section>
                            <div class="text-left"><p class="lead"><b>GROUND CONCERNS</b></p></div>
                            
                            <asp:TextBox ID="txt_concerns" runat="server" class="form-control" Height="250px" TextMode="MultiLine" ReadOnly="true" ForeColor="Black"></asp:TextBox>
 
                            <br/><div class="text-left"><p class="lead">The concern is about</p></div>
                            <asp:TextBox ID="txt_answer1" runat="server" class="form-control" ReadOnly="true" ForeColor="Black"></asp:TextBox>
                            
                            <br/><div class="text-left"><p class="lead">Recommended Dept To Process</div>
                            <asp:TextBox ID="txt_answer2" runat="server" class="form-control" ReadOnly="true" ForeColor="Black"></asp:TextBox>
                            
                            <br/><div class="text-left"><p class="lead">Can it be solved?</p></div>
                            <asp:TextBox ID="txt_answer3" runat="server" class="form-control" ReadOnly="true" ForeColor="Black"></asp:TextBox>
                            
                            <br/><div class="text-left"><p class="lead">Proposed Response</p></div>
                            <asp:TextBox ID="txt_answer4" runat="server" class="form-control" ReadOnly="true" ForeColor="Black"></asp:TextBox>

                            <section id="analytics"></section>
                            <br/>
                            <br/><div class="text-left"><p class="lead"><b>VISUAL ANALYTICS</b></p></div>
                            <hr/>
                            
                            <div class="text-right">
                            <p class="wow lightSpeedIn">
                            
                            <%--<a href="http://localhost:4848/extensions/MyMashup/MyMashup.html" target="_blank">Open Full View</a>--%>
                            
                            <asp:LinkButton ID="link_qlik_full_view" runat="server" ForeColor="White">Open Full View</asp:LinkButton>
                            </p>
                            </div>
                            
                            <div class="intrinsic-container intrinsic-container-16x9">
                            <iframe runat="server" src='http://localhost:4848/extensions/MyMashup/MyMashup.html' style='height:100%;' id="qlik_frame" name="qlik_frame" ></iframe>
                            </div>
                            
                            <section id="article"></section>
                            <br/>
                            <br/><div class="text-left"><p class="lead"><b>RELEVANT ARTICLES</b></p></div><hr/>
                            
                            <div class="form-group text-center">
                            <asp:Panel ID="pnl_hdb_websites" runat="server"></asp:Panel>
                            <div>
                            <br/><asp:TextBox ID="txt_articles_not_found" runat="server" class="form-control" ReadOnly="true"></asp:TextBox>
                            <!--
                            <asp:LinkButton ID="btn_link_google" runat="server" class="btn btn-default">Relevant Websites</asp:LinkButton>
                            -->
                            <div class="form-group text-right">
                            <asp:LinkButton ID="btn_link_back" runat="server" class="btn btn-default" OnClick="btn_link_back_Click">Let's Submit A New Concern</asp:LinkButton>
                            </div>

                        </div>
            
       
                </div>

                 

            </div><br /><br />

        </div>

        
        
            

    </div>	

		</div>
	
    </div>
    </div>    
        
    </section>
    
    <!-- /Section: contact -->
    <!-- Footer section -->
<%--    <footer class="footer">
  <div class="footer-top section-tb">
    <div class="container">
      <div class="row">
        <div class="footer-col col-md-4">
          <h5>Our Office Location</h5>
          <p>Metro Railway Delhi 10042 India.<br>
            4512 0123 145689 / 9986523471<br>
            123@aspxtemplates.com</p>
          <p>Copyright © 2015 Delhi Inc. All Rights Reserved.<a href="http://www.aspxtemplates.com"> aspxtemplates.com</a></p>
        </div>
        <div class="footer-col col-md-3">
          <h5>Services We Offer</h5>
          <p>
          <ul>
            <li><a href="#">Digital Strategy</a></li>
            <li><a href="#">Websites</a></li>
            <li><a href="#">Videography</a></li>
            <li><a href="#">Social Media</a></li>
            <li><a href="#">User Experience</a></li>
          </ul>
          </p>
        </div>
        <div class="footer-col col-md-3">
          <h5>Like us Share us</h5>
          <ul class="footer-share">
            <li><a href="#"><i class="fa fa-facebook"></i></a></li>
            <li><a href="#"><i class="fa fa-twitter"></i></a></li>
            <li><a href="#"><i class="fa fa-linkedin"></i></a></li>
            <li><a href="#"><i class="fa fa-google-plus"></i></a></li>
          </ul>
        </div>
         <div class="footer-col col-md-2">
          <h5>Follow</h5>
          <ul class="footer-share">
            <li><a href="#"><i class="fa fa-facebook"></i></a></li>
            <li><a href="#"><i class="fa fa-twitter"></i></a></li>
            <li><a href="#"><i class="fa fa-linkedin"></i></a></li>
            <li><a href="#"><i class="fa fa-google-plus"></i></a></li>
          </ul>
        </div>
      </div>
    </div>
  </div>
  <!-- footer top --> 
  
</footer>--%>
    <!-- Footer section -->

    <script src="js/jquery.js" type="text/javascript"></script>
    <script src="js/bootstrap.min.js" type="text/javascript"></script>
    <script src="js/jquery.easing.min.js" type="text/javascript"></script>
    <script src="js/jquery.flexslider-min.js"></script>
    <script src="js/jquery.fancybox.pack.js"></script>
    <script src="js/wow.js" type="text/javascript"></script>
    <script src="js/retina.min.js"></script>
    <script src="js/modernizr.js"></script>
    <script src="js/main.js"></script>
    <script type="text/javascript">
        //WOW Scroll Spy
        var wow = new WOW({
            //disabled for mobile
            mobile: false
        });
        wow.init();
    </script>
    </form>
</body>
</html>