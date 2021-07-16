<template>
    <div class="header-wrapper">
        <div class="logo-wrapper">
            KDCM
        </div>
        <div class="navigation-bar-wrapper">
            <ul class="navigation-bar">
                <li class="navigation-bar-item"><router-link to="/">Home</router-link></li>
                <li class="navigation-bar-item"><router-link to="Decks">Decks</router-link></li>
            </ul>
        </div>
    </div>
</template>

<script>

</script>

<style scoped>
.header-wrapper {
    background: #47597e;
    width: 100%;
    height: 80px;
    margin: auto;
    padding: 5px;
}
.logo-wrapper {
    height: 70%;
    font-size: 40px;
    font-family: Verdana;
    color: white;
    font-weight: bold;
    margin: 0px 0px 0px 10px
}

.navigation-bar-wrapper {
    width: 80%;
    margin: auto;
    height: 30%;
}

.navigation-bar {
    list-style: none;
    margin: auto;
    text-align: center;
    padding: 0px;
}

.navigation-bar-item {
    display: inline-flex;
    margin: 0px 10px;
}

.navigation-bar-item a {
    color: white;
    text-decoration: none;
    font-weight: 500;
}

.navigation-bar-item a:hover {
    text-decoration: underline;
}

.navigation-bar-item a:active {
    color: orange;
}
</style>