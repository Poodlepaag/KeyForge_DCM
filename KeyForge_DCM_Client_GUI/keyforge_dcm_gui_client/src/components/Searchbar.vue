<template>
    <input type='text' id="search-field" placeholder="Search for decks..." @keyup="search">
</template>

<script>
    export default {
        methods: {
            handleClick(){
                $('#search-field').attr("placeholder", "");
            },

            search(){
                this.$store.state.searches = $('#search-field').val()
            }
        }
    }
</script>

<style scoped>
#search-field {
    width: 400px;
    height: 40px;
    padding-left: 10px;
    border-radius: 5px;
    border-style: solid;
    border-width: 2px;
    border-color: rgb(207, 207, 207);
    font-size: 25px;
}
</style>

<!--CHILD COMPONENT OF HOME-->