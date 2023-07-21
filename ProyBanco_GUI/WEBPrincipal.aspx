<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WEBPrincipal.aspx.cs" Inherits="ProyBanco_GUI.WEBPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Seccion 1.5: Imagen Central -->
    <figure id="imagen_central">
        <div class="bxslider">
            <div><img src="Images/Slide_1.png"/></div>
            <div><img src="Images/Slide_2.png"/></div>
            <div><img src="Images/Slide_3.png"/></div>
            <div><img src="Images/Slide_4.jpg"/></div>
        </div>
    </figure> <!-- imagen_central -->

    <!-- Sección 4: Nuestros Objetivos -->
    <section id="objetivos" class="espaciado">
        <div class="container">
            <h2><i class="fa-solid fa-grip-lines-vertical"></i> Nuestros Objetivos</h2>
            <p>Nuestro objetivo principal es poder incrementar la calidad de vida de nuestros clientes, ayundando a mejorar el manejo de su dinero. Los pilares de nuestro sistema son:</p>
            <div class="fila">
                <article class="columna centrar_texto">
                    <h3 class="resaltar">Seguridad</h3> <!-- resaltar -->
                    <i class="fa-solid fa-shield-halved"></i>
                    <p class="bordes">Mantener segura la información de nuestros clientes es una prioridad para nosotros.</p> <!-- bordes -->
                </article> <!-- columna / centrar_texto -->

                <article class="columna centrar_texto">
                    <h3 class="resaltar">Tecnología</h3> <!-- resaltar -->
                    <i class="fa-solid fa-microchip"></i>
                    <p class="bordes">Desarrollar soluciones de tecnología para mejorar la experiencia de nuestros clientes</p> <!-- bordes -->
                </article> <!-- columna / centrar_texto -->
            </div> <!-- fila -->
        </div> <!-- container -->
        
    </section> <!-- objetivos / espaciado -->

    <!-- Sección 4.5: Nuestros Servicios -->
    <article id="servicios" class="espaciado">
        <div class="container">
            <h2><i class="fa-solid fa-grip-lines-vertical"></i> Nuestros Servicios</h2>
            <div class="fila centrar_cajas">
                <div class="columa">
                    <p><i class="fa-brands fa-bitcoin bordes fa-fw"></i> Compatibilidad con Criptoactivos.</p> <!-- bordes -->
                    <p><i class="fa-solid fa-memory bordes fa-fw"></i> Servicio de almacenamiento en la nube.</p> <!-- bordes -->
                    <p><i class="fa-solid fa-server bordes fa-fw"></i> Servicio disponible las 24 horas.</p> <!-- bordes -->
                </div> <!-- columna -->
                <div class="columa">
                    <p><i class="fa-solid fa-coins bordes fa-fw"></i> Manejo de divisas actualizadas.</p> <!-- bordes -->
                    <p><i class="fa-solid fa-phone-volume bordes fa-fw"></i> Consejeria económica para clientes.</p> <!-- bordes -->
                    <P><i class="fa-solid fa-cash-register bordes fa-fw"></i> Estimación de ahorros y gastos.</P> <!-- bordes -->
                </div> <!-- columna / linea_inter -->
            </div> <!-- fila / centrar_cajas -->
        </div> <!-- container -->
    </article> <!-- servicios / espaciado -->
</asp:Content>
