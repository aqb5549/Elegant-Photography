# Elegant-Photography
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Elegant Photography</title>
	<!-----------------------------JQUERY AREA----------------------->
	<!--CDN Content Delivery Network-->
	 <!--Load the jquery minified version: no comments, no whitespace, streamed-->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <!--<script src="scripts/jquery.min.js"></script>-->
    <!--Get Locally from our Server-->
    <!--<script src="scripts/jquery.js"></script>-->
	
	<!-----------------------------JSON DATA AREA----------------------->
    <script>
        var packageItems = [
            {"itemID": 1,"packageType": "Camera","cost": 200.00},
            {"itemID": 2,"packageType": "50mm Camera Lens", "cost": 70.00 },
            {"itemID": 3,"packageType": "35mm Camera Lens", "cost": 85.00 },
            {"itemID": 4,"packageType": "200mm Camera Lens", "cost": 110.00 },
            {"itemID": 5,"packageType": "Camera and your choice of any lens", "cost": 285.00 },
		 	{"itemID": 6,"packageType": "Light Kit","cost": 65.00},
	 		{"itemID": 7,"packageType": "Backdrops","cost": 50.00},
			{"itemID": 8,"packageType": "Tripods/Stands","cost": 50.00-100.00},
			{"itemID": 9,"packageType": "Total Package(Including professional photographer)","cost": 1000.00},
        ];
    </script>
    
    <!-----------------------------META DATA AREA----------------------->
    <!--Meta tags can provide search engines with information about the site-->
    <!--Metadata is always passed as name/value pairs.-->
    <meta charset="utf-8" />
    <meta name="description" content="Photography Shop">
    <meta name="keywords" content="Photography, ">
    <meta name="author" content="Row 3">
	
	<!-----------------------------CSS STYLE RULES AREA------------------>
    <!--This is an external style sheet reference-->
    <link rel="stylesheet" type="text/css" href="styles/common.css" />
    <!--This is an internal/embedded style sheet rule -->
    <style type="text/css">
        /*HTML Style Rule*/
		h1 {
            color: green !important; 
            /*text-align: center;*/
        }
		nav {
		width: 100%; /*Uses 100% width of the screen*/
		height: 60px;
		font-size: 24px;
		/*Families: Serif Fonts, Sans-Serif Fonts, Monospace Fonts*/
		/*font-family: "Times New Roman", Times, serif;*/
		font-family: "Comic Sans MS", cursive, sans-serif;  /*No barbs*/
		font-weight: bold;
		text-align: center;
		text-shadow: 6px 4px 3px #333333; /*CSS3 feature*/
		background-color: purple;   
		border-radius: 8px; /*CSS3 feature rounded edges*/
		}
		/*Unordered list in the nav area*/
		nav ul {
			height: auto;
			padding: 10px 0px;
			margin: 0px;
		}
		/*List item in the nav area*/
		nav li { 
			display: inline; /*position text horizontally*/
			padding: 25px; 
		}
		/*page's margin and size*/
		#page {
			width:900px;margin:0px auto;
			background-color: grey;
			background-position: center;
			background-repeat: repeat;
  			 background:white;
}
		/*Anchor in the nav area*/
		nav a {
			text-decoration: none;  /*removes underline*/
			color: #FFFFFF;    /*White*/
			padding: 13px;
			/*padding: 8px 8px;
			padding: 8px 8px 8px 8px;*/
		}
		/*Anchor in the nav area when the Mouse Hovers over the area*/
		nav a:hover {
			color: #05E9FF; /*Indiglo*/
			background-color: #8CDD81;/*Green Soap*/
		}
		footer li {
			display: inline; /*position text horizontally*/
			padding: 20px; 
		}
		footer a {
			text-decoration: none; /*removes underline*/
		}
	
    .auto-style1 {
		margin-left: 0px;
	}
	
    </style>
</head>
<body id="page">
<!-----------------------------HEADER AREA----------------------->
    <header>
	    <!-- float allows elements to float next to each other right, left, none or inherit-->
		<!-- You can clear the float left, right, both, none, inherit (from parent element)-->
     	<div style="float:left;width:80px;height:80px" >
			&nbsp;<img src="http://0.s3.envato.com/files/118332966/wedding%20photography_80.jpg" alt="photo logo" class="auto-style1" height="96" width="146" ></div>
		<!-- You can text-align: left, right, center, justify, initial (default value), inherit (from parent element)-->
		<div style="background-color:black; text-align: center; font-size: 200%;color:blue;">
			Elegant Photography 			</div>
			<!-----------------------------NAVIGATION DIV----------------------->
    <nav>
        <div>
            <ul>
                <li><a href="#home" id="navHome" class="links" rel="home">Home Page</a></li>
                <li><a href="#photo" id="navPhoto" class="links" rel="menu">Photography</a></li>
                <li><a href="#rent" id="navRent" class="links" rel="about">Rent Us</a></li>
            </ul>
        </div>
    </nav>
</header>
        <p>&nbsp;</p>
        <!-----------------------------HOME AREA----------------------------->
        
       <div id="home"> 

<h1>Welcome To Elegant-Photography's Webpage</h1> 
<p> 
Here on our website, you will get the opprotunity to rent camera equiptment 
for your own personal use. We have the best camera equiptment for anyone to rent, at an affordable price.
We have cameras, lenses, backdrops, lighting kits and much much more. You can even rent a professional photographer to
to take the pictures for you. Why waste all of that money on expensive camera quiptment when you can just rent it
here at Elegant Photography! </a></p> 
<p>&nbsp;</p> 

<img src="http://images.fineartamerica.com/images-medium-large-5/first-sunset-at-surat-bay-may-2014-cyndilu-miller.jpg"> 

<p >We intend to provide people with the best photography expierence they 
will ever have, but without breaking the bank. We offer the cheapest rental prices in the entire state.
We want people to feel like profesional photographers, but the best part is that you dont need to buy all of that
equiptment in order to feel like that!</p>
</div>
                <!-----------------------------Photography AREA----------------------------->
        <div id="photo" style="display:none">
            <h1>Examples</h1>
            <aside>sidebar</aside>
            <img src="http://www.markcapilitan-art.com/wp-content/uploads/2012/08/28-933-page/mtn09.jpghttp://www.markcapilitan-art.com/wp-content/uploads/2012/08/28-933-page/mtn09.jpg">
            <section>distinct title and region</section>
            <article>self-contained composition (syndication) in a doc</article>
        </div>
        <!-----------------------------Rent AREA---------------------------->
        <div id="rent" style="display:none">
            <h1>Rent the Equiptment</h1>
           	<p> You can hire us to take the picture or rent the equipment to do it yourself. </p>
        </div>

<!-----------------------------TERMS AREA-----------------------------(Source: http://www.bennadel.com/coldfusion/privacy-policy-generator.htm#primary-navigation)-->
        <div id="terms" style="display:none"><!----invisible by default--->

            <h1>Web Site Terms and Conditions of Use</h1>

<h3>1. Terms</h3>

<p>
	By accessing this web site, you are agreeing to be bound by these 
	web site Terms and Conditions of Use, all applicable laws and regulations, 
	and agree that you are responsible for compliance with any applicable local 
	laws. If you do not agree with any of these terms, you are prohibited from 
	using or accessing this site. The materials contained in this web site are 
	protected by applicable copyright and trade mark law.
</p>

<h3>2. Use License</h3>

<ol type="a">
	<li>
		Permission is granted to temporarily download one copy of the materials 
		(information or software) on Row 3 photography's web site for personal, 
		non-commercial transitory viewing only. This is the grant of a license, 
		not a transfer of title, and under this license you may not:
		
		<ol type="i">
			<li>modify or copy the materials;</li>
			<li>use the materials for any commercial purpose, or for any public display (commercial or non-commercial);</li>
			<li>attempt to decompile or reverse engineer any software contained on Row 3 photography's web site;</li>
			<li>remove any copyright or other proprietary notations from the materials; or</li>
			<li>transfer the materials to another person or "mirror" the materials on any other server.</li>
		</ol>
	</li>
	<li>
		This license shall automatically terminate if you violate any of these restrictions and may be terminated by Row 3 photography at any time. Upon terminating your viewing of these materials or upon the termination of this license, you must destroy any downloaded materials in your possession whether in electronic or printed format.
	</li>
</ol>

<h3>3. Disclaimer</h3>

<ol type="a">
	<li>
		The materials on Row 3 photography's web site are provided "as is". Row 3 photography makes no warranties, expressed or implied, and hereby disclaims and negates all other warranties, including without limitation, implied warranties or conditions of merchantability, fitness for a particular purpose, or non-infringement of intellectual property or other violation of rights. Further, Row 3 photography does not warrant or make any representations concerning the accuracy, likely results, or reliability of the use of the materials on its Internet web site or otherwise relating to such materials or on any sites linked to this site.
	</li>
</ol>

<h3>4. Limitations</h3>

<p>
	In no event shall Row 3 photography or its suppliers be liable for any damages (including, without limitation, damages for loss of data or profit, or due to business interruption,) arising out of the use or inability to use the materials on Row 3 photography's Internet site, even if Row 3 photography or a Row 3 photography authorized representative has been notified orally or in writing of the possibility of such damage. Because some jurisdictions do not allow limitations on implied warranties, or limitations of liability for consequential or incidental damages, these limitations may not apply to you.
</p>
			
<h3>5. Revisions </h3>

<p>
	The materials appearing on Row 3 photography's web site could include technical, typographical, or photographic errors. Row 3 photography does not warrant that any of the materials on its web site are accurate, complete, or current. Row 3 photography may make changes to the materials contained on its web site at any time without notice. Row 3 photography does not, however, make any commitment to update the materials.
</p>

<h3>6. Links</h3>

<p>
	Row 3 photography has not reviewed all of the sites linked to its Internet web site and is not responsible for the contents of any such linked site. The inclusion of any link does not imply endorsement by Row 3 photography of the site. Use of any such linked web site is at the user's own risk.
</p>

<h3>7. Site Terms of Use Modifications</h3>

<p>
	Row 3 photography may revise these terms of use for its web site at any time without notice. By using this web site you are agreeing to be bound by the then current version of these Terms and Conditions of Use.
</p>

<h3>8. Governing Law</h3>

<p>
	Any claim relating to Row 3 photography's web site shall be governed by the laws of the State of Pennsylvania without regard to its conflict of law provisions.
</p>

<p>
	General Terms and Conditions applicable to Use of a Web Site.
</p>



<h2>
	Privacy Policy
</h2>

<p>
	Your privacy is very important to us. Accordingly, we have developed this Policy in order for you to understand how we collect, use, communicate and disclose and make use of personal information. The following outlines our privacy policy.
</p>

<ul>
	<li>
		Before or at the time of collecting personal information, we will identify the purposes for which information is being collected.
	</li>
	<li>
		We will collect and use of personal information solely with the objective of fulfilling those purposes specified by us and for other compatible purposes, unless we obtain the consent of the individual concerned or as required by law.		
	</li>
	<li>
		We will only retain personal information as long as necessary for the fulfillment of those purposes. 
	</li>
	<li>
		We will collect personal information by lawful and fair means and, where appropriate, with the knowledge or consent of the individual concerned. 
	</li>
	<li>
		Personal data should be relevant to the purposes for which it is to be used, and, to the extent necessary for those purposes, should be accurate, complete, and up-to-date. 
	</li>
	<li>
		We will protect personal information by reasonable security safeguards against loss or theft, as well as unauthorized access, disclosure, copying, use or modification.
	</li>
	<li>
		We will make readily available to customers information about our policies and practices relating to the management of personal information. 
	</li>
</ul>

<p>
	We are committed to conducting our business in accordance with these principles in order to ensure that the confidentiality of personal information is protected and maintained. 
</p>
        </div>
		
		
		
		 <!-----------------------------CONTACT AREA---------------------------->
        <div id="contact" style="display:none"><!----invisible by default--->

            <h1>Contact Page Section</h1>
			<ul>
				<li>E-mail: Row3Photography@gmail.com</Li>
				<li>Phone Number: 215-555-0156</Li>
				<li>Address: 2155 Row Street Philadelphia, PA, 19114</Li>
			
			</ul>
        </div>
		
		
		
		<!-----------------------------FOOTER AREA---------------------------->
		<footer>
            <div>
                <ul>
                    <li>Row 3 Photography&copy; 2016</li>
                    <li><a href="#terms" id="ftrTerms">Terms of Use</a></li>                    
                    <li><a href="#contact" id="ftrContact">Contact Us</a></li>
                </ul>
            </div>
        </footer>
        
        
       <!----------------------------JAVASCRIPT AREA-------------------------->
 		<script>
            //When the DOM document is loaded in the browser
            $(document).ready(function () {
                //When home link is clicked show home area
                $("#navHome").click(function (event) {
                    $("#home").show();
                    $("#photo, #rent, #terms, #contact").hide();
                });
                //When menu link is clicked show menu area
                $("#navPhoto").click(function (event) {
                    $("#photo").show();
                    $("#home, #rent, #terms, #contact").hide();
                });
                //When about link is clicked show about area
                $("#navRent").click(function (event) {
                    $("#rent").show();
                    $("#home, #photo, #terms, #contact").hide();
                });
                //When terms link is clicked show terms area
                $("#ftrTerms").click(function (event) {
                    $("#terms").show();
                    $("#home, #photo, #rent, #contact").hide();
                });
                                //When contact link is clicked show contact area
                $("#ftrContact").click(function (event) {
                    $("#contact").show();
                    $("#home, #photo, #rent, #terms").hide();
                });
                                 //Load the Menu Area with the JSON data
                for (var i in packageItems){
                    $("#rent").append("<div>"
                        + "Type: " + packageItems[i].packageType
                        + "Cost: " + packageItems[i].cost.toFixed(2)
                        + "</div>");
                 }
              //Get JSON data from Data
               // $.getJSON("Data/rent.json")
                 //.done(function (json) {
                   //    $("#rent").html("<div>" + json.rent[0].packageType + "</div>");
                //})
                  // .fail(function () {
                    //   alert("Error connecting to rent.json")
                   //});
            });
        </script>

       
</body>

</html>
