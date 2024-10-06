-- このluaスクリプトは、EA_066_012.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
CamaraG = set_camera({2.22235, 1.15611, -0.499,   1.12416, 35.62909, 0,   16.14572})
-- ▲直接出力
-- ▼直接出力
CameraK = set_camera({2.27245, 1.17257, 2.2549,   0.53321, 356.08, 0,   16.14572})
-- ▲直接出力
-- ▼直接出力
CameraL = set_camera({1.1389, 1.0617, 4.6112,   358.8126, 284.4893, 0,   16.14572})
-- ▲直接出力
-- ▼直接出力
CameraM = set_camera({-0.71813, 1.5806, 0.82874,   7.38435, 293.6061, 0.39866,   16.14572})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0009")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:いやあ、平和だなあ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120002")

	change_face(Actor002,"Normal")

	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120003")

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:おかげで皆それぞれ目の前のことにまっすぐ向き合える
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120005")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ヴォールス★★:
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0120006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120007")


	--★★アーサー★★:もうこの地にバルバロイの脅威はない…とすれば今までのように守りを固める必要はないわけだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0019")
-- ▲直接出力

	--★★ヴォールス★★:
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0120009")


	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120010")


	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120011")


	--★★ヴォールス★★:………
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0120012")

	open_select_window_tag(Actor001,"Normal","EA_066_0120014","EA_066_0120015")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0008")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ヴォールス★★:ここにいてはまずいということでしょうか
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0120018")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0048")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:…あ！勘違いするなよ！？<br>別に肩たたきをしたいわけじゃないからな！？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120019")

	change_face(Actor002,"Surprise")

	--★★アーサー★★:そりゃあ、お前がログレスにいてくれれば<br>これほど心強いことはないさ、王としてはな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120020")

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0019")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:だがそれは甘えというものだと<br>最強騎士に言われてな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120021")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0040")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ヴォールス★★:民を守ることは俺の務め<br>務めを果たすことが俺の為すべきことだと
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0120024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0010")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:お前はそう言うだろうと思ったよ<br>その気持ちに偽りがないことも知っている
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120025")

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0019")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:だがな…俺はもう役割や責務に<br>皆を縛り付けたくはないんだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120026")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★アーサー★★:実を言うとな、お前に暇を与えるように<br>言い出したのはランスなんだよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120028")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ヴォールス★★:
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0120029")

-- ▼直接出力
setup_small_camera_start(CameraL)
-- ▲直接出力

	--★★アーサー★★:「海で自由に生きていた彼には<br>広い海にやり残したことがあるかもしれない」
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120030")


	--★★アーサー★★:「ヴォールスは責任感の強い男だ役目があればずっとそれを果たそうとする」
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120031")


	--★★アーサー★★:「だがもう、己が思うまま<br>往きたい道を歩んでいいはずだ」――とな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ヴォールス★★:…気持ちは、ありがたい<br>だが、俺は――…
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0120033")

-- ▼直接出力
CloseTalkWindow()
wait_time(2.5)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0019")
-- ▲直接出力

	--★★ヴォールス★★:………
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0120035")

-- ▼直接出力
setup_small_camera_start(CameraM)
-- ▲直接出力

	--★★アーサー★★:モルドレッドとクラリスは確か<br>巡礼の旅に出たんだったか…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120036")

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0011")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:あいつのことだ。魔獣でも狩りながら<br>危なっかしいクラリスを見守っているのだろうな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:皆、それぞれ自分の道を歩み出して活き活きとしているじゃないか
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:お前もそろそろ、自分の青春を謳歌することを<br>考えてもいいんじゃないか？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120039")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ヴォールス★★:青春？今更、そんな
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0120040")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★アーサー★★:そう難しく考えなくてもいい
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120041")

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0009")
-- ▲直接出力

	--★★アーサー★★:青春を楽しむのに、遅すぎるということはないぞ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_066_0120043")


	--★★ヴォールス★★:………
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0120044")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
