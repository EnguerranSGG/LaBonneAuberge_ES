window.onload = () => {

    // On commence par chercher toutes les étoiles 
    const stars = document.querySelectorAll('.la-star');

    // On va maintenant chercher l'input avec la note du client

    const notation = document.querySelector('#notation');

    // On peut désormais boucler sur les étoiles pour leur ajouter un event listener

    for (star of stars) {

        // On ajoute un event listener sur chaque étoile

        star.addEventListener('mouseover', function () {
            resetStars();
            this.style.color = 'orange';

            // L'élément précédent dans le DOM et de même niveau

            let previousStar = this.previousElementSibling;

            // On boucle tant qu'il y a une étoile précédente

            while (previousStar) {
                previousStar.style.color = 'orange';
                previousStar = previousStar.previousElementSibling;
            }
        })

        star.addEventListener('click', function () {
            notation.value = this.dataset.value;
        })
    }

    function resetStars() {
        for (star of stars) {
            star.style.color = 'black';
        }
    }
}