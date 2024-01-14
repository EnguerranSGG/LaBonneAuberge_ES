window.onload = () => {
    const stars = document.querySelectorAll('form .la-star');
    const feedbackSections = document.querySelectorAll('.Pseudo_Notation');

    let selectedStar = null;

    for (const star of stars) {
        star.addEventListener('mouseover', function () {
            resetStars();
            highlightStars(this);
        });

        star.addEventListener('click', function () {
            selectedStar = this;
            document.querySelector('#notation').value = this.dataset.value;
            oldNotationFeedback();
        });

        star.addEventListener('mouseout', function () {
            if (!selectedStar) {
                resetStars();
            } else {
                highlightStars(selectedStar);
            }
        });
    }

    function resetStars() {
        for (const star of stars) {
            star.style.color = 'black';
            star.classList.remove('las');
            star.classList.add('lar');
        }
    }

    function highlightStars(selectedStar) {
        for (const star of stars) {
            star.style.color = selectedStar && star.dataset.value <= selectedStar.dataset.value ? 'orange' : 'black';
            star.classList.add('las');
            star.classList.remove('lar');
        }
    }

    function oldNotationFeedback() {
        feedbackSections.forEach((feedback, index) => {
            const old_notation = feedback.querySelector('.old_notation');
            const old_stars = feedback.querySelectorAll('.la-star');
            const old_value = parseInt(old_notation.value);

            if (!isNaN(old_value)) {
                for (const old_star of old_stars) {
                    old_star.style.color = old_star.dataset.value <= old_value ? 'orange' : 'black';
                    old_star.classList.add('las');
                    old_star.classList.remove('lar');
                }
            }
        });
    }

    oldNotationFeedback();
};



/** window.onload = () => {

    // On commence par chercher toutes les étoiles 
    const stars = document.querySelectorAll('form .la-star');
    const old_stars_notation = document.querySelectorAll('.Pseudo_Notation i');
    const old_stars = document.querySelectorAll('.Pseudo_Notation .la-star');


    // On va maintenant chercher l'input avec la note du client

    const notation = document.querySelector('#notation');
    const old_notations = document.querySelector('.old_notation');

    // On peut désormais boucler sur les étoiles pour leur ajouter un event listener

    for (star of stars) {

        // On ajoute un event listener sur chaque étoile

        star.addEventListener('mouseover', function () {
            resetStars();
            this.style.color = 'orange';
            this.classList.add('las');
            this.classList.remove('lar');

            // L'élément précédent dans le DOM et de même niveau

            let previousStar = this.previousElementSibling;

            // On boucle tant qu'il y a une étoile précédente

            while (previousStar) {
                previousStar.style.color = 'orange';
                previousStar.classList.add('las');
                previousStar.classList.remove('lar');
                previousStar = previousStar.previousElementSibling;
            }
        })

        star.addEventListener('click', function () {
            notation.value = this.dataset.value;
        })

        star.addEventListener('mouseout', function () {
            resetStars(notation.value);
        })
    }

    function resetStars(notation = 0) {
        for (star of stars) {
            if (star.dataset.value > notation) {
                star.style.color = 'black';
                star.classList.add('lar');
                star.classList.remove('las');
            } else {
                star.style.color = 'orange';
                star.classList.add('las');
                star.classList.remove('lar');
            }
        }
    }

    function oldNotationFeedback() {
        old_stars_notation.forEach((old_star, index) => {
        
            const old_notation = old_notations[index];
            const starValue = old_star.dataset.value;
    
            if (old_notation && starValue > old_notation.value) {
                old_star.style.color = 'black';
                old_star.classList.add('lar');
                old_star.classList.remove('las');
            } else {
                old_star.style.color = 'orange';
                old_star.classList.add('las');
                old_star.classList.remove('lar');
            }
        });
    }

    oldNotationFeedback();
} */