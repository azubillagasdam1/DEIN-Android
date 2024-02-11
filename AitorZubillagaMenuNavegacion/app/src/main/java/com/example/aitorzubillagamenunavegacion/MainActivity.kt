package com.example.aitorzubillagamenunavegacion
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.MenuItem
import androidx.annotation.DrawableRes
import androidx.annotation.StringRes
import androidx.appcompat.widget.Toolbar
import com.example.aitorzubillagamenunavegacion.PageFragment
import com.example.aitorzubillagamenunavegacion.R
import com.google.android.material.badge.BadgeDrawable
import com.google.android.material.bottomnavigation.BottomNavigationView

class MainActivity : AppCompatActivity() {
    // Declarar lateinit para inicializar más adelante
    private lateinit var bottomNavigationView: BottomNavigationView
    private lateinit var favBadge: BadgeDrawable
    private lateinit var settingsBadge: BadgeDrawable

    private val badgeCounts = mutableMapOf<Int, Int>()
    private val badgeClicks = mutableSetOf<Int>()

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        val toolbar: Toolbar = findViewById(R.id.toolbar)
        setSupportActionBar(toolbar)

        // Inicializar bottomNavigationView
        setupBottomMenu()

        // Obtener y configurar el distintivo para la página favorita
        favBadge = bottomNavigationView.getOrCreateBadge(R.id.page_fav)
        favBadge.number = 1000

        // Obtener y configurar el distintivo para la página de ajustes
        settingsBadge = bottomNavigationView.getOrCreateBadge(R.id.page_settings)
        settingsBadge.isVisible = true
    }

    private fun setupBottomMenu() {
        bottomNavigationView = findViewById(R.id.bottom_navigation)
        bottomNavigationView.setOnItemSelectedListener { item -> onItemSelectedListener(item) }
        bottomNavigationView.setSelectedItemId(R.id.page_home)

        // Configurar distintivos para cada elemento del menú y establecer contadores
        for (i in 0 until bottomNavigationView.menu.size()) {
            val menuItem = bottomNavigationView.menu.getItem(i)
            val badge = bottomNavigationView.getOrCreateBadge(menuItem.itemId)
            badge.isVisible = false
            badge.badgeGravity = BadgeDrawable.TOP_START
            badgeCounts[menuItem.itemId] = 0
        }

    }

    private fun onItemSelectedListener(item: MenuItem): Boolean {
        val itemId = item.itemId
        if (!badgeClicks.contains(itemId)) {
            val badge = bottomNavigationView.getOrCreateBadge(itemId)
            badge.isVisible = true
            badgeClicks.add(itemId)
        }

        // Incrementar contador y actualizar distintivo
        val currentCount = badgeCounts[itemId] ?: 0
        badgeCounts[itemId] = currentCount + 1
        val badge = bottomNavigationView.getOrCreateBadge(itemId)
        badge.number = badgeCounts[itemId] ?: 0

        when (itemId) {
            R.id.page_home -> {
                showPageFragment(R.drawable.ic_home, R.string.bottom_nav_home)
                return true
            }
            R.id.page_fav -> {
                showPageFragment(R.drawable.ic_fav, R.string.bottom_nav_fav)
                return true
            }
            R.id.page_search -> {
                showPageFragment(R.drawable.ic_search, R.string.bottom_nav_search)
                return true
            }
            R.id.page_settings -> {
                showPageFragment(R.drawable.ic_settings, R.string.bottom_nav_settings)
                return true
            }
            else -> throw IllegalArgumentException("Item not implemented: $itemId")
        }
    }

    private fun showPageFragment(@DrawableRes iconId: Int, @StringRes title: Int) {
        val fragment = PageFragment.newInstance(iconId)
        supportFragmentManager.beginTransaction()
            .setCustomAnimations(R.anim.bottom_nav_enter, R.anim.bottom_nav_exit)
            .replace(R.id.container, fragment)
            .commit()
    }
}
