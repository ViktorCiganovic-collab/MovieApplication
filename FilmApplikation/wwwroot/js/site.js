


window.addEventListener('scroll', function () {
    var heading = document.querySelectorAll('.heading');  // Select all .skillsDiv elements
    var windowHeight = window.innerHeight;  // Viewport height
    var scrollTop = window.scrollY;  // Scroll position

    heading.forEach(function (div) {
        var elementOffset = div.getBoundingClientRect().top + scrollTop;  // Position of each div
        if (scrollTop + windowHeight > elementOffset) {
            div.classList.add('visible');  // Add the "visible" class when it's in view
        }
    });
});