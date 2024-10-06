-- このluaスクリプトは、MA_01B900_06.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_017)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_014,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_014)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_013)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115060)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ケイ", "落胆")
-- ▲直接出力

	--★★ケイ★★:私へ公務を丸投げしていたのが<br>まさかこのためとはな
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B900_060002")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:引き継ぎはバッチリだったろう？
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_060003")

-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ケイ★★:足らないものだらけだ
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B900_060004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "悩む")
-- ▲直接出力

	--★★アーサー★★:伝えられることは伝えたつもりだが…
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_060005")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★ケイ★★:足らぬな<br>貴公と生きる時間が
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B900_060006")

-- ▼直接出力
 --PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力

	--★★アーサー★★:………不出来な義弟で
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_060007")

-- ▼直接出力
 --PlayPartVoice("ケイ", "落胆")
-- ▲直接出力

	--★★ケイ★★:まったくだ
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B900_060008")

	change_face(Actor004,"Normal")

	--★★ケイ★★:…ガウェインには？
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B900_060010")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:ほかの生徒と同様に
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_060011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ケイ★★:…「知らぬ間に療養の旅に出た」などと伝えて<br>納得してくれるかどうか
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B900_060012")

-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力

	--★★アーサー★★:出そうだろう？<br>自由気ままにフラフラと
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_060013")

	open_select_window_tag(Actor001,"Normal","MA_01B900_060014","MA_01B900_060015")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…なにも知らせずにいるのは残酷だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_060017")

	change_face(Actor001,"Sad")

	--★★ノワール★★:いつか帰って来るかもしれない<br>どこかで生きているかもしれないと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_060018")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ガラハッド★★:…そう信じることが<br>救いになることもある
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_060019")

	change_face(Actor005,"Sad")

	--★★ガラハッド★★:お爺様もきっと、そう考えていたんだ
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_060020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:真実を伝えないのも優しさかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_060022")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:師匠もそうだったな<br>俺たちは振り回されもしたが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_060023")

-- ▼直接出力
 --PlayPartVoice("ケイ", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ケイ★★:…ガウェインにとって<br>アーサーは尊敬する人物のひとりであり
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B900_060024")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★ケイ★★:己の目標でもあるからな
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B900_060025")

	change_face(Actor006,"Sad")

	--★★フィエナ★★:じゃあ…なおさらだね
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_060026")

	goto Block1end

::Block1end::
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ケイ", "悩む")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ケイ★★:まさかアーサー…貴公のその奔放な性格まで<br>このときのために演じていたわけではあるまいな
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B900_060028")


	--★★アーサー★★:…これまでよく支えてくれた<br>ケイ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_060029")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ケイ★★:………私は、見送らぬ
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B900_060030")

	PlayAction(Actor004,"to  Std_Sad02")
	change_face(Actor004,"Sad")

	--★★ケイ★★:我が愚弟は旅立ったのだ<br>…身勝手にな
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B900_060031")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
se_play("SE_ADV_MA_01B900_06_Door_Close")
wait_time(CHARA_IN_WAIT)
Hide(Actor004)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力

	--★★アーサー★★:覚えてるか、ランス
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_060033")


	--★★アーサー★★:初めて会ったときのこと
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_060034")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:…あまり思い出さないでくれ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_060035")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★フィエナ★★:えっ、もしかして恥ずかしい話？
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_060036")

	change_face(Actor005,"Sad")

	--★★ガラハッド★★:姉上…
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_060037")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:流浪の末に辿り着いた学園…<br>なりふり構ってはいられなかった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_060038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:昔のノワールと<br>同じ目をしていたな
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_060039")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115060)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
