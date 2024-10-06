-- このluaスクリプトは、MA_01108_56.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111016_03","111016_03_h")
Include("content_adv_advsmall_111016_03","Template111016_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111016_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111016_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111016_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111016_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111016_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_004)
	InitializeTemplateRandomCamera111016_03()
	InitializeTemplate111016_03()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111016)
	Actor001 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101056","001","101056001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ガラハッド★★:…
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01108_560002")

	change_face(Actor002,"Smile")

	--★★アーサー★★:世話になりました<br>ぺレス王
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01108_560003")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ぺレス★★:聞き及んだぞ<br>継承者の決断を
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01108_560004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ぺレス★★:そして大敵の台頭…
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01108_560005")

	change_face(Actor003,"Anger")

	--★★ぺレス★★:継承者が完全に覚醒した以上<br>これが最後の戦いとなろう
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01108_560006")


	--★★ぺレス★★:我らが力を合わせねばならぬ時期が<br>来ていることは理解しておるつもりだ
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01108_560007")

	change_face(Actor003,"Normal")

	--★★ぺレス★★:ランスロット卿──
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01108_560008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ぺレス★★:我が銀卓騎士団もまた<br>そなたらと運命をともにしよう
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01108_560009")


	--★★ランスロット★★:ペレス王…？
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01108_560010")


	--★★ぺレス★★:そなたの想いに従えるか定かではないが<br>我らは継承者の劔に殉じよう
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01108_560011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★アーサー★★:どういう…おつもりです。ペレス王？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01108_560012")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ぺレス★★:いずれわかる
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01108_560013")


	--★★ぺレス★★:…そなたらは世界の救済を<br>我らはそなたらの救済を
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01108_560014")


	--★★アーサー★★:…ローマがバルバロイを得たとなれば<br>物量、戦力ともにこちらが圧倒的不利だ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01108_560015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:最初の武器が導いたノワールのＧＳと<br>聖杯伝承にすべては懸かっている…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01108_560016")


	--★★ランスロット★★:往こう、ノワール<br>最強騎士が並んで歩む
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01108_560018")


	--★★ノワール★★:父さんたちに<br>不格好なところはみせられない
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01108_560019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:先へと進みながら<br>遺していかねばならない
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01108_560020")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ランスロット★★:誰もが、最も強く生き抜ける道を
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01108_560021")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111016)
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101056","001","101056001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111016_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
