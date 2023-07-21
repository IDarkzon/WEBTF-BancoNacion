function irArriba(pxPantalla){
    window.addEventListener('scroll', () => {
        var scroll = document.documentElement.scrollTop;
        var botonArriba = document.getElementById('scroll')
        if(scroll > pxPantalla) {
            botonArriba.style.opacity=1;
            botonArriba.style.transform='scale(1)';
        }else {
            botonArriba.style.transform='scale(0)';
            botonArriba.style.opacity=0;
        }
    })
}irArriba(350);