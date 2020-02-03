const btnAddCourse = document.querySelector(".add-course-btn");
const frmContainer = document.querySelector(".frm-container");
let flag = false;

btnAddCourse.addEventListener('click', function () {
    if (!flag) {
        frmContainer.style.height = "230px";
        btnAddCourse.innerHTML = "Hide Form";
        flag = true;
    } else {
        frmContainer.style.height = "0px";
        btnAddCourse.innerHTML = "Add Course";
        flag = false;
    }
})