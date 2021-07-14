<template>
    <input type='text' id="search-field" placeholder="Search decks..." @keyup="search">
</template>

<script>
    export default {
        methods: {
            search(){
                this.$store.state.searches = $('#search-field').val()
            }
        }
    }
</script>

<style scoped>
#search-field {
    width: 800px;
    max-width: 80%;
    height: 40px;
    margin: 10px;
    padding-left: 10px;
    border-radius: 5px;
    border-style: solid;
    border-width: 2px;
    border-color: rgb(207, 207, 207);
    font-size: 25px;
}
</style>

<!--CHILD COMPONENT OF HOME-->