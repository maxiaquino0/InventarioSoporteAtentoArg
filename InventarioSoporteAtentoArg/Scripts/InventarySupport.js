$(function () {
    $('#ObjectTypeID').change(
            function () {
                var objectType = $(this).find('option:selected').text();
                if (objectType !== "CPU") {
                    $('#SpeedProcessor').attr('disabled', false);
                    $('#ModelProcessor').attr('disabled', false);
                    $('#QuantityHDD').attr('disabled', false);
                    $('#QuantityRam').attr('disabled', false);
                } else {
                    $('#SpeedProcessor').attr('disabled', true);
                    $('#ModelProcessor').attr('disabled', true);
                    $('#QuantityHDD').attr('disabled', true);
                    $('#QuantityRam').attr('disabled', true);
                }
            }
        );
});