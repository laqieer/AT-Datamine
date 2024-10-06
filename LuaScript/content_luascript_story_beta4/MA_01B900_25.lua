-- このluaスクリプトは、MA_01B900_25.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112031_01","112031_01_h")
Include("content_adv_advsmall_112031_01","Template112031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112031_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_004)
	InitializeTemplateRandomCamera112031_01()
	InitializeTemplate112031_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112031)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:推理するまでもないけれど
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B900_250002")


	--★★クレア★★:アーサー王を連れ去った魔女の居場所は<br>サラスの都とみていいわね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B900_250003")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定3")
-- ▲直接出力

	--★★ボールス★★:そのこころは？
	Talk(Actor003,"CHRNAME_BORS","speech","L","MA_01B900_250004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★クレア★★:ローマ残党への対応はギネヴィア殿下が<br>先陣を切って行っている
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B900_250005")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クレア★★:今のところブリテン島内で<br>魔女の目撃談は上がっていない
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B900_250006")

-- ▼直接出力
 --PlayPartVoice("クレア", "悩む")
-- ▲直接出力

	--★★クレア★★:コルベニック城…という線もあるけれど<br>彷徨う銀卓騎士がアーサーを狙う可能性がある
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B900_250007")


	--★★クレア★★:それは面倒だし、他人の住まいを愛の巣に…<br>なんて性格じゃあなさそう
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B900_250008")

-- ▼直接出力
 --PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:となれば向かう場所は限られる
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B900_250009")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:妖精の命を捧げないまま<br>サラスに入れるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_250010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★クレア★★:そもそも聖杯を扱うに足る者を<br>選定、見出すための存在こそが妖精…
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B900_250011")

-- ▼直接出力
 --PlayPartVoice("クレア", "悩む")
-- ▲直接出力

	--★★クレア★★:妖精の命を捧げるのは<br>聖杯の力を解放するためであって…
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B900_250012")

	PlayAction(Actor002,"to  Std_Worry")

	--★★クレア★★:サラスへの入場は副次的な効果なのかもね<br>そして妖精当人がいればそのまま入れる…とか
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B900_250013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ボールス★★:だが妖精マーリンは連れ去られ…
	Talk(Actor003,"CHRNAME_BORS","speech","L","MA_01B900_250014")


	--★★クレア★★:モルガンはサラスの都で<br>バルバロイの王の生誕を待つだけ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B900_250015")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("クレア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クレア★★:もはや妖精のいない私たちには<br>手を出せない最悪のシチュエーションね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B900_250017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B900_250018","MA_01B900_250019")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_250021")

-- ▼直接出力
 --PlayPartVoice("クレア", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クレア★★:…最後の敵が育ち切るのを<br>待つしかないなんてね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B900_250022")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ボールス★★:ランスロットの迷いを責めるわけにもいかん<br>こればかりは運命を呪うしかない
	Talk(Actor003,"CHRNAME_BORS","speech","L","MA_01B900_250023")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ほかに、妖精がいるとしたら…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_250025")

-- ▼直接出力
 --PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:もしもそんな人がいるのなら<br>きっと清らかで純真ね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B900_250026")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★クレア★★:世界平和に命を懸ける覚悟とともに<br>申し出てくれるんじゃないかしら
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B900_250027")

	goto Block1end

::Block1end::
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(112031)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	system.PreLoadRequest(CameraAssetBundleName112031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
