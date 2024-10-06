-- このluaスクリプトは、MA_01A900_22.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111061_01","111061_01_h")
Include("content_adv_advsmall_111061_01","Template111061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111061_01,CameraPos111061_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName111061_01,CameraPos111061_01_002)
	InitializeTemplateRandomCamera111061_01()
	InitializeTemplate111061_01()
-- ▼直接出力
INIT_CHRPOS(Actor001,{2.582, 0, -1.55,   315},false)
-- ▲直接出力
-- ▼直接出力
INIT_CHRPOS(Actor002,{3.356, 0, -0.934,   290},false)
-- ▲直接出力
-- ▼直接出力
kisspoint = {0.842, 0, 0.191,   129.6688}
-- ▲直接出力
-- ▼直接出力
kisspointstart = {0.65, 0, 0.35,   129.6688}
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
CameraEx = set_camera({1.078,1.47,1.24,   0,224.494,0,22})
FX_DoF = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111061)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","002","101011002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
	Appear(Actor001)
	set_enable_auto_lookat(Actor001,false)
	Appear(Actor002)
	turn_lookat_position(Actor001,CharaPos111061_01_003[1],CharaPos111061_01_003[2],CharaPos111061_01_003[3],0)
	turn_lookat_position(Actor002,CharaPos111061_01_002[1],CharaPos111061_01_002[2],CharaPos111061_01_002[3],0)
	PlayActionDirect(Actor001,"to Wlk")
	PlayActionDirect(Actor002,"to Wlk")
	slidemove(Actor001,CharaPos111061_01_003[1],CharaPos111061_01_003[2],CharaPos111061_01_003[3],2.0)
	slidemove(Actor002,CharaPos111061_01_002[1],CharaPos111061_01_002[2],CharaPos111061_01_002[3],2.0)
	wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
turn(Actor001,0, CharaPos111061_01_003[4], 0,0.3)
turn(Actor002,0, CharaPos111061_01_002[4], 0,0.3)
wait_time(2.0)
-- ▲直接出力

	--★★ギネヴィア★★:誰もいないふたり旅ね
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220002")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ゴハン持って来れば良かったね<br>ガレスにお願いしてさ
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220004")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat(Actor001,true)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:寝床とかあるのかな<br>わたしはねえ、ベッドなきゃ寝れないんだあ
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220005")

	open_select_window_tag(Actor001,"Normal","MA_01A900_220006","MA_01A900_220007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:早く聖杯を安置する場所を探そう<br>ルーシャスの動向も気になるし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_220009")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:そうね
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:着替えも持って来れば良かったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_220013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:長旅になったらさ！<br>必要だよね！
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:旅先で買っちゃうのもいいよね！<br>ここにはなんもなさそうだけど！
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220015")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
character_in_move_walk(Actor002,CharaPos111061_01_005,1.0)
Camera002 = InitializeCharaCamera(CameraAssetBundleName,CameraPos111061_01_005,Actor002)
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:あとはやっぱりお金ね<br>使える場所あるのかしらそもそも
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220017")


	--★★ギネヴィア★★:ね。こういうときこそアレよ！
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220018")

	open_select_window_tag(Actor001,"Normal","MA_01A900_220020","MA_01A900_220021")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:異国のコイン！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_220023")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:この国で使えるコインが<br>１枚くらいないかしら
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220024")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:自慢のコレクションが<br>火を噴くわ～
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220025")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:アレって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_220027")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:もう…<br>察しが悪いなぁ
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220028")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:わたしが集めてたコインが<br>あったでしょ？
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220029")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ねえねえ。わたしがあげたコイン<br>まだ持っててくれてるんだよね
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220031")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:使えなくて困ってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_220032")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:物持ちいいじゃん
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220033")

	change_face(Actor001,"Normal")

	--★★ノワール★★:殿下のご指導のたまもの
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_220034")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:見せて
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220035")

-- ▼直接出力
PlayActionDirect(Actor001,"to LookFor")
se_play("SE_ADV_MA_01B112_49_Cloth")
wait_time(1.0)
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to Show")

	--★★ノワール★★:ほら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_220037")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:ごめんね、あの、このまえ泣いちゃって、さ<br>はずかしい…
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220039")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(2.0)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:けど、もういいんだ<br>世界を平和にしよ
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220041")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:色んな人に託されて来たものがあるでしょ<br>それは捨てられないよ
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220042")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:わたしのワガママで<br>逃げたりやめたりできないし
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220043")

	open_select_window_tag(Actor001,"Normal","MA_01A900_220045","MA_01A900_220046","MA_01A900_220047")
	if is_select(1) then
		goto Block3_1
	elseif is_select(2) then
		goto Block3_2
	elseif is_select(3) then
		goto Block3_3
	end

::Block3_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネヴィアがそう望むなら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_220049")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:「そう望む」ってなに？<br>どっち？
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220050")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:聖域化するってこと？<br>やめるってこと？
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220051")

	goto Block3end

::Block3_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:継承者としてすべきことをするよ<br>亡くした人もたくさんいる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_220053")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:うん、そうだね、それがいいよ
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220054")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ノワールのためにも<br>みんなのためにも、それが一番
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220056")

	goto Block3end

::Block3_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:ワガママ言ったっていいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_220058")

	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:ええ～無責任だあ
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220059")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:「世界は滅べ！わたしを守って！」<br>とかワガママ言ってもいい？ほんとに？
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220060")

	goto Block3end

::Block3end::
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:平気だよ、わたし
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220062")

	open_select_window_tag(Actor001,"Normal","MA_01A900_220064","MA_01A900_220065")
	if is_select(1) then
		goto Block4_1
	elseif is_select(2) then
		goto Block4_2
	end

::Block4_1::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:忘れないから<br>絶対に
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_220067")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:うん
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220068")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…ノワールは、強いね
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_220070")

	goto Block4end

::Block4_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:うそだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_230002")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…どうして？
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_230003")

	change_face(Actor003,"Normal")

	--★★テロップ★★:「平気な顔、してたいのよ…！」
	Talk(Actor003,"","simple","L","MA_01A900_230005")

-- ▼直接出力
setup_small_camera_start(CameraEx)
on_active(FX_DoF)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:………覚えてて、くれてるの？
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_230006")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_WAIT_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★テロップ★★:「現実を見るのが、怖いの…っ」
	Talk(Actor003,"","simple","L","MA_01A900_230007")

	goto Block4end

::Block4end::
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
kisspoint = {0.842, 0, 0.191,   129.6688}
kisspointstart = {0.65, 0, 0.35,   129.6688}
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_postprocess_preload("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
	InitializeLoad_Preload()
	load_area_scene_preload(111061)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","002","101011002","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
