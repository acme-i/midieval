﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hqub.MusicBrainz.API.Resources {
    using System;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Constants {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Constants() {
        }
        
        /// <summary>
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Hqub.MusicBrainz.API.Resources.Constants", typeof(Constants).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à -area-beginarea-endarea-arid-artist-artistaccent-alias-begin-comment-country-end-ended-gender-ipi-sortname-tag-type-.
        /// </summary>
        internal static string ArtistQueryParams {
            get {
                return ResourceManager.GetString("ArtistQueryParams", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à -arid-artist-artistname-creditname-comment-country-date-dur-format-isrc-number-position-primarytype-puid-qdur-recording-recordingaccent-reid-release-rgid--rid-secondarytype-status-tid-tnum-tracks-tracksrelease-tag-type-video-.
        /// </summary>
        internal static string RecordingQueryParams {
            get {
                return ResourceManager.GetString("RecordingQueryParams", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à -arid-artist-artistname-comment-creditname-primarytype-rgid-releasegroup-releasegroupaccent-releases-release-reid-secondarytype-status-tag-type-.
        /// </summary>
        internal static string ReleaseGroupQueryParams {
            get {
                return ResourceManager.GetString("ReleaseGroupQueryParams", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à -arid-artist-artistname-asin-barcode-catno-comment-country-creditname-date-discids-discidsmedium-format-laid-label-lang-mediums-primarytype-puid-quality-reid-release-releaseaccent-rgid-script-secondarytype-status-tag-tracks-tracksmedium-type-.
        /// </summary>
        internal static string ReleaseQueryParams {
            get {
                return ResourceManager.GetString("ReleaseQueryParams", resourceCulture);
            }
        }
    }
}