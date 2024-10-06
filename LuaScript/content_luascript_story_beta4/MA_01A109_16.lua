-- このluaスクリプトは、MA_01A109_16.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_113011_02","113011_02_h")
Include("content_adv_advsmall_113011_02","Template113011_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-123,CharaPos113011_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName113011_02,CameraPos113011_02_004)
	Camera002 = SetTemplate("Actor002",44,CharaPos113011_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName113011_02,CameraPos113011_02_002)
	InitializeTemplateRandomCamera113011_02()
	InitializeTemplate113011_02()
-- ▼直接出力
set_common_look_at(Actor001,Actor002,1.0)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor001,1.0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(113012)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:『誘拐』以来ね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_160002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ようこそ<br>わたしのプライベートへ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_160003")

	open_select_window_tag(Actor001,"Normal","MA_01A109_160005","MA_01A109_160006","MA_01A109_160007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:いい部屋だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_160009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:…ホントいい部屋<br>お姉ちゃんがね、いつも綺麗にしてくれて
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_160010")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:もっと気軽に遊びに来てくれてよかったんだよ？<br>ノワール
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_160011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いい匂いだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_160013")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:ひとこと目がそれ？<br>乙女の部屋に入ってひとこと目がそれ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_160014")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:すっっごい気持ち悪いよ、ノワール<br>絶対やめたほうがいいよ仮にいい匂いだとしても
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_160015")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ベッドが大きいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_160017")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:いきなりベッドに話題持ってく？<br>やらしいよノワール
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_160018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:大きいのは確かだし<br>寝心地もサイコーだけどね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_160019")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
wait_time(WAIT_TIME_NORMAL)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ちょっと恩着せがましいこと、言うね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_160021")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:わたしの居場所はもう<br>ここじゃないの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_160022")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:今のわたしの居場所は、あなたの隣
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_160023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:だからこの部屋とはお別れなの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_160024")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…どういうこと？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_160025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:これからはこのお部屋以上に<br>居心地の良い場所にしてねってコト
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_160026")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:重責だな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_160027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:そうよ、自覚なさい<br>そのために見せたげたんだから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_160028")


	--★★ノワール★★:けど…別にこの部屋を<br>出る必要はないんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_160029")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:だめ<br>これはわたしのけじめだから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_160030")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そう、か…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_160031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:だけどまあ…<br>ちょっと名残惜しいんだ。実はね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_160032")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:だから今夜は、一緒にいてよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_160033")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(113012)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName113011_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
