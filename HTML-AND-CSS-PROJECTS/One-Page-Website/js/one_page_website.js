//Function to open the modal
function openModal() {
    document.getElementById("myModal").style.display = "block";
}

//Function to close the modal
function closeModal() {
    document.getElementById("myModal").style.display = "none";
}

var slideIndex = 1;
showSlides(slideIndex);

//Function for the next/previous controls
function plusSlides(n) {
    showSlides(slideIndex += n);
}

//Function for the thumbnail image controls
function currentSlide(n) {
    showSlides(slideIndex = n);
}

//Function to show the different slides
function showSlides(n) {
    var i;
    var slides = document.getElementsByClassName("mySlides");
    var dots = document.getElementsByClassName("thumb");
    var captionText = document.getElementById("caption");
    if (n > slides.length) { slideIndex = 1 }
    if (n < 1) { slideIndex = slides.length }
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    slides[slideIndex - 1].style.display = "block";
    dots[slideIndex - 1].className += " active";
    captionText.innerHTML = dots[slideIndex - 1].alt;
}