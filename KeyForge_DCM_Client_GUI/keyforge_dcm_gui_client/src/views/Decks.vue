<template>
    <div class="create-deck-wrapper">
        <button class="normal-button">Create Deck</button>
    </div>
    <div class="searchbar-wrapper">
        <Searchbar />
    </div>
    <div>
        <div v-if="search === undefined || search === ''">
            <ul class="list-of-results">
                <li v-for="deck in decks" :key="deck.deckId">
                    <h3>#{{ deck.deckId }} - {{ deck.deckName }}</h3>
                    <hr class="difference-line">
                </li>
            </ul>
        </div>
        <div v-else>
            <ul class="list-of-results" v-for="deck in decks" :key="deck.deckId">
                <li v-if="deck.deckName.toLowerCase().includes(search)">
                    <h3>#{{ deck.deckId }} - {{ deck.deckName }}</h3>
                    <hr class="difference-line">
                </li>
            </ul>
        </div>
    </div>
</template>

<script>
    import Searchbar from '../components/Searchbar.vue'
    export default {
        data() {
            return {
                decks: [],
            }
        },
        components: {
            Searchbar,
        },
        computed: {
            search(){
                return this.$store.state.searches
            },
        },
        mounted() {
            this.decks = this.$store.state.decks
        },
        beforeUnmount(){
            this.$store.state.searches = ''
        }
    };
</script>

<style>
.list-of-results {
  list-style: none;
  width: 90%;
  margin: auto;
  padding: 0px;
}

.searchbar-wrapper {
    text-align: center;
    margin: 40px auto;
}

.difference-line {
    opacity: 20%;
}

.create-deck-wrapper {
    width: 90%;
    margin: auto;
    padding-top: 20px;
    text-align: center;
}

.normal-button {
    width: 200px;
    height: 50px;
    border-radius: 10px;
    background-color: #47597e;
    color: white;
}

.normal-button:hover {
    opacity: 70%;
}

.normal-button:active {
    background-color: orange;
}
</style>
