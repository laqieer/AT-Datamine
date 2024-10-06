-- このluaスクリプトは、EA_003_022.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
lookat_weight(Actor001,0.45,0.1,0.85,0.2)
keep_ik_lookat(Actor001,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor003,0.45,0.1,0.85,0.2)
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101016","002","101016002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101001","002","101001002","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:俺たちの勝利だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0220001")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネマウア★★:ええ、見事でした。我々も精進しなければね、殿下
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0220002")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "否定")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:………まだよ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0220003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0220004")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力

	--★★ギネヴィア★★:こんなんじゃ足りないわ！でもどうしたら――…
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0220005")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(1.0)
set_enable_auto_lookat(Actor003,false)
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",0.8)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:そうだわ！次は１対１で勝負しなさい、ティルフィング！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0220006")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0220007")

-- ▼直接出力
PlayPartVoice("ティルフィング", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ティルフィング★★:私と１対１で…？
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","EA_003_0220008")

-- ▼直接出力
set_enable_auto_lookat(Actor003,true)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "怒り")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:殿下、落ち着いてくださいバイブス学の授業でやることではありません
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0220009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★ギネマウア★★:ランスロット先生に叱られても知りませんよ
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0220010")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0021")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:ううう～…でも、でも…どうしてもティルフィングと戦いたいんだもの
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0220011")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なんでだよ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0220012")

	open_select_window_tag(Actor001,"Normal","EA_003_0220014","EA_003_0220015")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:やめろってそんなことをしてもしょうがないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0220017")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:そ、そんなことないわよ！必ずチャンスをモノにしてみせるわ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0220018")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:チャンス？？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0220019")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "激怒")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ギネヴィア★★:ていうか、止めないでよ！ノワールならわかるでしょ、わたしの気持ち！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0220020")

-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:サッパリわからないけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0220021")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0038")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なら俺が代わりに戦うよバイブス同士だし、そのほうがいいだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0220023")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0020")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:そ、それじゃ意味がないのよ！！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0220024")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:意味って？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0220025")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0021")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:それは…今ここで言えないけど！！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0220026")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:？？？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0220027")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
change_face(Actor004,"Normal")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to  Std_Worry")
-- ▲直接出力
-- ▼直接出力
wait_time(2.6)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ティルフィング","0007")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ティルフィング★★:…いいですよ。そこまで言うなら
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","EA_003_0220029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0029")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:え！？いいの！？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0220030")

-- ▼直接出力
wait_time(0.3)
CloseTalkWindow()
set_enable_auto_lookat(Actor001, false)
PlayActionDirect(Actor001,"to Wlk")
lookat_delay_weight_reset(Actor001 , 0.6)
turn_chara(Actor001,14,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0041")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、ダメだティルフィングここ最近ずっと戦い詰めじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0220031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:調子もよくなさそうだしあまり無理しないほうがいい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0220032")

-- ▼直接出力
PlayPartVoiceDirect("ティルフィング","0040")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★ティルフィング★★:大丈夫ですよ。まだ力は残っていますから
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","EA_003_0220033")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ティルフィング★★:戦うことで少しでもアナタの気が済むなら
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","EA_003_0220034")

	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:あ…
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0220035")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
set_enable_auto_lookat(Actor001, true)
turn_chara(Actor001,-58,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ギネヴィアは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0220036")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:え…わたし？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0220037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:キミはティルフィングに無理をさせたいのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0220038")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ギネヴィア★★:ち、違うわ！そんなつもりじゃなくて…
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0220039")


	--★★ギネヴィア★★:ただ、その――汚名挽回がしたいだけよ！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0220040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0220041")

-- ▼直接出力
PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネマウア★★:殿下…
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0220042")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0019")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:な、なによぉ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0220043")

	PlayAction(Actor004,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ティルフィング","swim_0009")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ティルフィング★★:ギネヴィア様…汚名は返上するものですよ
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","EA_003_0220044")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0030")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:！！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0220046")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0021")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:へ、返上！返上だから！！！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0220047")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01C111_20_Bell")
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(3.0)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ティルフィング","swim_0002")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ティルフィング★★:授業は終わりのようですねでは、私は失礼します
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","EA_003_0220049")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
-- ▲直接出力
-- ▼直接出力
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力

	--★★ギネヴィア★★:あ…
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0220051")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
hide_image(BLACK_WHITE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(BLACK_WHITE_TIME)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どうしたんだよ、ギネヴィアなんかキミ、この間からちょっと変だぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0220052")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力

	--★★ギネヴィア★★:だって…
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0220053")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:殿下が空回りしているのはいつものことですよ
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0220054")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:空回り？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0220055")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0021")
-- ▲直接出力

	--★★ギネヴィア★★:だって…<ruby=マジバト>本気のぶつかり合い</ruby>、したかったんだもの
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0220056")

	PlayAction(Actor003,"to  Std_Surp")

	--★★ギネヴィア★★:あなたの妹さんが言ったんじゃない！本気のぶつかり合いで仲良くなれるって！！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0220058")

	change_face(Actor001,"Sad")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0220059")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネマウア★★:ね？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0220060")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力

	--★★ノワール★★:…なるほど確かに、友達作りが下手みたいだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0220061")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101016","002","101016002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101001","002","101001002","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
