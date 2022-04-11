function ChangePage(pageId) {
    var courseId = window.location.pathname.split('/')[2];
    $.ajax({
        url: "/Course/GetCourseComments?pageId=" + pageId + "&courseId=" + courseId,
        type: "get",
        beforeSend: function () {
            $(".loading").show();
        },
        complete: function () {
            $(".loading").hide();
        }
    }).done(function (data) {
        $("#comments").html(data);
    });
}

function replyComment(id) {
    $("#reply-comment-id").val(id);
    var elment = document.getElementById("comments");
    elment.scrollIntoView();
    $("#comment_text").select();
}

function DeleteComment(commentId) {
    var courseId = window.location.pathname.split('/')[2];

    swal({
        title: "آیا از حذف اطمینان دارید ؟",
        icon: "warning",
        buttons: ["خیر", "بله"]
    }).then((isOk) => {
        if (isOk) {
            $.ajax({
                url: "/Course/DeleteComment?commentId=" + commentId + "&courseId=" + courseId,
                type: "get",
                beforeSend: function () {
                    $(".loading").show();
                },
                complete: function () {
                    $(".loading").hide();
                }
            }).done(function (data) {
                if (data === "Deleted") {
                    swal({
                        title: "اعملیات با موفقیت انجام شد",
                        icon: "success",
                        button: "باشه"
                    }).then((isOk) => {
                        location.reload();
                    });
                } else {
                    swal({
                        title: "اعملیات به مشکل برخورد کرد",
                        icon: "error",
                        button: "باشه"
                    });
                }
            });
        }
    });
}
$(".send-Comment").submit(function () {
    var courseId = window.location.pathname.split('/')[2];
    event.preventDefault();
    var answerId = $("#reply-comment-id").val();
    var text = $("#comment_text").val();
    if (!text || text.length <= 4) {
        swal({
            title: "متن نظر را وارد کنید",
            icon: "error",
            button: "باشه"
        });
        return;
    }
    var courseComment = {
        Comment: text,
        Answer: answerId,
        CourseId: courseId
    }
    $.ajax({
        url: "/Course/AddComment",
        type: "post",
        data: courseComment,
        beforeSend: function () {
            $(".loading").show();
        },
        complete: function () {
            $(".loading").hide();
        }
    }).done(function (data) {
        $("#comment_text").val("");
        $("#reply-comment-id").val("null");

        if (data === "Error") {
            swal({
                title: "عملیات ناموفق بود",
                icon: "error",
                button: "باشه"
            });
        } else {
            if (data === "Success") {
                swal({
                    title: "نظر شما باموفقیت ثبت شد",
                    icon: "success",
                    button: "باشه"
                }).then((isOk) => {
                    location.reload();
                });
            } else {
                swal({
                    title: "نظر شما باموفقیت ثبت شد",
                    icon: "success",
                    button: "باشه"
                });
                $(".list-comment").prepend(data);
                var count = $(".count").html();
                count = parseInt(count);
                count += 1;
                $(".count").html(count);
            }

        }

    });
});

$(function () {
    var courseId = window.location.pathname.split('/')[2];
    $("#vot").load("/Course/CourseVote?id="+courseId);
})

function vote(vote) {
    var courseId = window.location.pathname.split('/')[2];
    $("#vot").fadeOut('slow');
    $("#vot").load("/Course/AddVote?id=" + courseId +"&vote=" + vote);
    $("#vot").fadeIn('slow');
}

