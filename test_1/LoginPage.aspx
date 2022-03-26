<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="test_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.0.js"></script>
    <link href="Estilos/Estilos.css" rel="stylesheet" />
    <title>Login</title>
</head>
    <style type="text/css">
	:root{
		--var-prin: #1379e1;
		--var-second: #242635;
	}
	body{
		background: var(--var-second) !important ;
		overflow-y:hidden;
	}
	.lava{
		position: absolute;
		top: 0;
		right: 0;
		left: 0;
		bottom: 0;
		z-index: -1;
	}
	.box-login{
		z-index: 10;
	}
	.box-login .input{
		border: none;
		background: transparent;
		color: white;
		font-size: 20px;
	}
	.box-login .input-box{
		background: #ffffff7a;
		width: 100%;
		color: white;
		margin-bottom: 25px;
		padding: 25px;
		border-radius: 100px;
	}
	.box-login .btn-enviar{
		background: var(--var-second);
		width: 100%;
		color: white;
		margin-bottom: 25px;
		padding: 25px;
		border-radius: 100px;
		font-size: 20px;		
	}
	.box-login .btn-enviar:hover{
		background: var(--var-prin);
		border-color: var(--var-second);
		color: white;	
	}	
	.padre {
	   	display: table;
	   	height:100vh;
	    width: 100%;
	    max-width: 500px;
	    margin: 0 auto;	   
	}
	.lava .padre {
	    max-width: 100% !important; 
	}	
	.hijo {
	   display: table-cell;
	   vertical-align: middle;
	}	
	.input-box i, .input-box .input{
		display: inline-block;
	}
	.input-box i{
		color: var(--var-second);
		width: 5%;
		font-size: 20px;
	}	
	.input-box .input{
		width: 90%;
		outline: none;
	}

	.input-box ::placeholder { 
	  color: white;
	  opacity: 1;
	  font-size: 20px;
	}

	.input-box :-ms-input-placeholder {
	  color: white;
	  font-size: 20px;
	}

	.input-box ::-ms-input-placeholder {
	  color: white;
	  font-size: 20px;
	}	
	.title h1{
		color: white;
		text-transform: uppercase;
		font-size: 30px;
		font-weight: bold;
	}
	.title{
		width: 100%;
		text-align: center;
		margin-bottom: 25px;
		border: solid 3px white;
    	border-radius: 100px;
    	padding: 25px;	
		color: white;
	}
	@media (max-width: 900px){
		.box-login .btn-enviar{
			background: var(--var-prin) !important;

		}
		.box-login .btn-enviar:hover{
			background: var(--var-second);
			border-color: var(--var-prin);	
		}	
	}
</style>

<body class="">
	<div class="lava">
	<div class="padre">
		<div class="hijo">
			<div class="svg-burbuja hidden-xs">
			  <svg viewBox="0 0 589.48 518.05">
			      <defs>
			        <style>.cls-b{fill:url(#linear-gradient) !important;opacity: 1;}</style>
			        <linearGradient id="linear-gradient" x1="120.2" y1="320.62" x2="295.08" y2="17.71" gradientUnits="userSpaceOnUse">
			          <stop offset="0" stop-color="#1185fc"></stop>
			          <stop offset="0.14" stop-color="#1185fc"></stop>
			          <stop offset="0.38" stop-color="#1185fc"></stop>
			          <stop offset="0.68" stop-color="#1185fc"></stop>
			          <stop offset="1" stop-color="#1185fc"></stop>
			        </linearGradient>
			      </defs>
			       
			       <path id="p1" class="cls-b" d="M338.38,65.64c28.62,22,211.45,236.28-33.79,291.47-86.39,19.45-126.12-31.44-184.74-34.17C35,319,38,206.44,157.18,182.36,256.1,162.37,257.78,3.64,338.38,65.64Z">
			            <animate attributeName="d" values="M338.38,65.64c28.62,22,211.45,236.28-33.79,291.47-86.39,19.45-126.12-31.44-184.74-34.17C35,319,38,206.44,157.18,182.36,256.1,162.37,257.78,3.64,338.38,65.64Z;
			        M338.38,65.64c28.62,22,158,176.69-33.79,291.47-76,45.49-196.52,23.32-184.74-34.17C129,278.33,207,293.29,157.18,182.36,132.33,127,257.78,3.64,338.38,65.64Z;
			        M338.38,65.64C451.67,149,483.08,491.58,304.59,357.11c-76.26-57.44-212.51,17.53-184.74-34.17,50.48-93.94,143-80.42,37.33-140.58C-24.33,79,256.47,5.38,338.38,65.64Z;
			        M338.38,65.64c-70.71,210.69,178.16,220.63-33.79,291.47-25.59,8.56-177.83,24.11-184.74-34.17-5.52-46.61,107.42-41.23,37.33-140.58C77.67,69.67,370.73-30.76,338.38,65.64Z;
			        M338.38,65.64c28.62,22,211.45,236.28-33.79,291.47-86.39,19.45-126.12-31.44-184.74-34.17C35,319,38,206.44,157.18,182.36,256.1,162.37,257.78,3.64,338.38,65.64Z;" dur="20s" repeatCount="indefinite"></animate>
			       </path>
			     </svg>
			</div>			
		</div>
	</div>	
</div>

<div class="container">
    <div class="padre">
        <div class="box-login hijo">     
            <form id="form_login" runat="server">
                      <div class="title">
                            <asp:Label class="h1" ID="lbl_bienvenida" runat="server" Text="Process SA"></asp:Label>
                        </div>
                        <div class="input-box">
							<i class="fas fa-user"></i>
                            <asp:TextBox ID="tb_usuario" CssClass="input"  runat="server" placeholder="Rut" style="text-align: center"></asp:TextBox>
                        </div>
                        <div class="input-box">
							<i class="fas fa-lock"></i>
                            <asp:TextBox ID="tb_password" CssClass="input"  TextMode="Password" runat="server" placeholder="Contraseña" style="text-align: center"></asp:TextBox>
                        </div>
                   
                        <asp:Button ID="btn_ingresar" CssClass="btn btn-enviar" runat="server" Text="Ingresar" OnClick="btn_ingresar_Click" />
                   
            </form>
        </div>
    </div>
</div>

</body>
</html>