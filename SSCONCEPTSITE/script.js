let indice = 0;
const slides = document.querySelectorAll('.slide');

function mostrarSlide(cont){
    if(cont >= slides.length){
        indice = 0;
    } else if(cont < 0){
        indice = slides.length-1;
    } else{
        indice = cont;
    }
    slides.forEach(slide => slide.classList.remove('active'));
    slides[indice].classList.add('active');
}
function mudarSlide(x){
    mostrarSlide(indice + x);
}

