-- このluaスクリプトは、MA_01A111_08.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114091_01","114091_01_h")
Include("content_adv_advsmall_114091_01","Template114091_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114091_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName114091_01,CameraPos114091_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114091_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName114091_01,CameraPos114091_01_004)
	InitializeTemplateRandomCamera114091_01()
	InitializeTemplate114091_01()
-- ▼直接出力
load_image("104000140", "content_still_10400014_image", "104000140_StillImage")
tegami2 = setup_prop_object(10106003)
off_active(tegami2)
tegami_offset2 = {0,0,0,0,0,0}
turn_chara(Actor001, 110, 0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114091)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:尻込みしていられないと思ったんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_080002")


	--★★エレイン★★:「過ぎた時間は取り返しがつかない」<br>なんて言われたら
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_080003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:金言ね<br>誰が言ったのかしら
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_080004")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★エレイン★★:ふふ。きっと歴史に残る偉人ですよ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_080005")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:だけどエレイン<br>あなたは焦んなくたっていいのよ？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_080006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★エレイン★★:…急いじゃいますよ、やっぱり
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_080007")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ギネヴィア★★:わたしはね…<br>やれること全部やっときたいのよ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_080008")


	--★★ギネヴィア★★:ランスロットみたいに最強じゃないし<br>ディナタンみたいに傭兵やってたわけじゃない
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_080009")


	--★★ギネヴィア★★:エレインみたいに一生懸命<br>故郷を守り続けられるほど強くもない
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_080010")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:ログレスに来てからずっと<br>自分の弱っちさに腐ってただけ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_080011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:そんなわたしがみんなに追いつくには<br>どれだけ傷ついても走るしかない！と思うわけ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_080012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:きっと──…すぐだから
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_080013")


	--★★エレイン★★:………<dot>すぐ</dot>？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_080014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:うん。すぐ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_080016")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.3)
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:私があなたに<br>勝手に感じたシンパシー
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_080018")


	--★★エレイン★★:泣き言ひとつ口にしないで<br>飲み込んで戦い続けて──
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_080019")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ギネヴィア★★:いーのよ<br>言えないままで
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_080020")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera001)
PlayActionDirect(Actor002,"to LookFor")
wait_time(1.2)
-- ▲直接出力

	--★★ギネヴィア★★:エレイン？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_080022")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Show")
wait_time(1.5)
ShowImageItem("104000140")
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to ReadLetter")
on_active(tegami2)
on_parent(tegami2,Actor001, "Loc_weapon_constrint_L", tegami_offset2)
wait_time(1.3)
HideImageItem()
PlayActionDirect(Actor002,"to Std_Loop")
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ギネヴィア★★:「言えない気持ち　手紙にしませんか」…？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_080024")

	change_face(Actor002,"Normal")

	--★★エレイン★★:むかむかすることとか…いらいらすること、とか<br>キリがないほど書き出して…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_080026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★エレイン★★:あとで見返して<br>笑ってみるんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_080027")

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:…吐き出しちゃって、いいのかな
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_080028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:誰にも言えないことって絶対あります<br>身近な人であればあるほど
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_080029")

	PlayAction(Actor002,"to  Std_Talk")

	--★★エレイン★★:「愚痴に付き合わせていいのかな」とか<br>「この人も頑張ってるのに弱音吐けない」とか
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_080030")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:うわー。なんかすっっごいそう思ってた
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_080031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エレイン★★:とりとめのないことでもいいんです<br>あなたが私に。私があなたに
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_080032")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Shy")

	--★★エレイン★★:文通………しませんか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_080033")

	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Shy")

	--★★ギネヴィア★★:………イヤ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_080035")

	PlayAction(Actor002,"to  Std_Surp")

	--★★エレイン★★:…そう、ですか<br>お、お、お、おいそがしいですもんね…！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_080037")


	--★★ギネヴィア★★:もーあれはカンベン<br>だからね──
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_080038")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:差出人不明にならないなら、いいよ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_080040")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("104000140", "content_still_10400014_image", "104000140_StillImage")
setup_prop_object_preload(10106003)
tegami_offset2 = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(114091)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
