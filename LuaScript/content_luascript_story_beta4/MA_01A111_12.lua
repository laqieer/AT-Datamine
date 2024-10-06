-- このluaスクリプトは、MA_01A111_12.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_008)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110122_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110122_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_006)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
Hide(Actor001)
Hide(Actor003)
Hide(Actor002)
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
set_chara_pos_resetting(Actor002,{3.231, 0, -12.902,   270})
-- ▲直接出力
-- ▼直接出力
set_chara_pos_resetting(Actor003,{3.031, 0, -13.721,   270})
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ギネヴィア★★:…エレイン、今の腹具合は？
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A111_120002")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:折り返し地点ですね
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A111_120004")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_common_look_at(Actor007,Actor004)
 --PlayPartVoice("ラヴェイン", "肯定")
-- ▲直接出力

	--★★ラヴェイン★★:腹六分目に差しかかったところでしょうね
	Talk(Actor007,"CHRNAME_LOVEIN","speech","L","MA_01A111_120005")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ギネヴィア★★:折り返すな、もう引き返しなさい
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A111_120007")

-- ▼直接出力
 --PlayPartVoice("ギネマウア", "肯定3")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ギネマウア★★:テーブルマナーは見事に守られ<br>上品さすら漂わせながらこの大食漢…
	Talk(Actor005,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_120008")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
set_common_look_at(Actor006,Actor001)
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力

	--★★エレイン★★:あ、先輩、ガウェインさん、ラグネルさん！<br>よかったらご一緒しませんか？
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A111_120010")

-- ▼直接出力
local eeCamera = EntryData110122_01_02[1]
local startPos = EntryData110122_01_02[2] 
local goalPos = EntryData110122_01_02[3]  
local CameraTime1 = EntryData110122_01_02[4]
local CameraTime2 = EntryData110122_01_02[5]
local MoveTime = EntryData110122_01_02[6]
local TurnTime = EntryData110122_01_02[7]
load_exclusive_camera(eeCamera ,CameraAssetBundleName110122_01, CameraPos110122_01_102, Actor001)
eeCamera.CopyOffset(Camera001)
-- ▲直接出力
-- ▼直接出力
 --キャラを移動させる
on_active(Actor001)
on_active(Actor002)
on_active(Actor003)
set_pos(Actor001,startPos)
turn_lookat_position(Actor001,goalPos[1],goalPos[2],goalPos[3],0) --向きを行先に合わせる
PlayActionDirect(Actor001,"to Wlk")
PlayActionDirect(Actor002,"to Wlk")
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor001, goalPos[1],goalPos[2],goalPos[3] ,MoveTime)
slidemove(Actor002, 1.02, 0, -12.902 ,MoveTime + 0.2)
slidemove(Actor003, 0.69, 0, -13.721,MoveTime + 0.2)
-- ▲直接出力
-- ▼直接出力
 -- 俯瞰
on_camera(RndCamera090)

wait_time(CameraTime1)

on_camera(eeCamera)

	while eeCamera.IsPositionAnimationPlayng() do
		coroutine.yield()
	end

	Camera001.SetSkipOffset()

if manager ~= nil then
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
end
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor001, goalPos[4],0.3)
wait_time(0.2)
PlayActionDirect(Actor001,"to Std_Loop") 
turn_chara(Actor002, {0,-64,0},0.3)
turn_chara(Actor003, {0,-22,0},0.3)
wait_time(0.2)
PlayActionDirect(Actor002,"to Std_Loop") 
PlayActionDirect(Actor003,"to Std_Loop") 
-- ▲直接出力
	play_head_motion(Actor007, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "否定")
-- ▲直接出力

	--★★ラヴェイン★★:変わった妹で申し訳ありませんが…
	Talk(Actor007,"CHRNAME_LOVEIN","speech","L","MA_01A111_120011")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:むしろ気に入ったぜ。同席しようじゃねーか<br>イイ食いっぷりだと思うぜ、若干ヒいたけどな！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_120013")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)

-- ▲直接出力
-- ▼直接出力
set_animationcontroller(Actor001, "Com_m_SitController","to Sit01_Loop")
Camera001 = setup_small_camera_resetting(Actor001,CharaPos110122_01_007,CameraPos110122_01_007)
set_animationcontroller(Actor003, "Com_f_SitController","to Sit01_Loop")
Camera003 = setup_small_camera_resetting(Actor003,CharaPos110122_01_006,CameraPos110122_01_006)
set_animationcontroller(Actor002, "Com_m_SitController","to Sit01_Loop")
Camera002 = setup_small_camera_resetting(Actor002,CharaPos110122_01_008,CameraPos110122_01_008)
set_animationcontroller(Actor007,"Chr_009_01_StdController","to Std_Loop")
Camera007 = setup_small_camera_resetting(Actor007,CharaPos110122_01_002,CameraPos110122_01_002)
setup_template_moveobj_110122_01(7,true)
setup_template_moveobj_110122_01(8,true)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera001)
fadein(FADE_TIME)
wait_time(FADE_TIME + 1)
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラグネル", "挨拶")
-- ▲直接出力

	--★★ラグネル★★:ねえねえエレイン、聞いてもいーい？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_120015")

-- ▼直接出力
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★エレイン★★:お、おかわりを取ってきてからでも<br>よろしいでしょうか？
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A111_120016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラグネル", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:じゃ、あたしのあげる！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_120017")

-- ▼直接出力
 --PlayPartVoice("エレイン", "喜び")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★エレイン★★:ありがとうございます<br>それで、ご質問とはなんでしょう？
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A111_120018")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_end()
 --PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:デートはどーだったの！？！？<br>ギネヴィア様にも感想聞きたくて！！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_120020")

	open_select_window_tag(Actor001,"Normal","MA_01A111_120022","MA_01A111_120023","MA_01A111_120024")
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
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺は興味ないなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_120026")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラグネル★★:…ノワールってば、斜に構えちゃって
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_120027")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ギネヴィア★★:エレイン、わたし悲しい
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A111_120028")

-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★エレイン★★:よしよし、ギネヴィアさんよしよしです
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A111_120029")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネヴィア、デートはどうだった？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_120031")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ギネヴィア★★:あのね、すっごく楽しかったよ<br>もっとしたいなって思ったの
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A111_120032")

	change_face(Actor004,"Normal")

	--★★ギネヴィア★★:エレインともっと色んなところで<br>お話したいなって
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A111_120033")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:エレイン、ギネヴィアとは仲良くなれたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_120035")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★エレイン★★:なれました！<br>なれました、よね？
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A111_120036")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ギネヴィア★★:もっちろん！<br>ばっちり！！
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A111_120037")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★エレイン★★:あっ！そうだ、ギネヴィアさん<br>前に言ってたお願いごと！
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A111_120039")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ギネヴィア★★:えっ、えっ、今ここで言うの？
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A111_120040")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★エレイン★★:善は急げです！さあさあ！
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A111_120041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ギネヴィア★★:エレイン、あなたホント<br>化けの皮がはがれて来たって感じがするわ…
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A111_120042")

-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★エレイン★★:えへ
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A111_120043")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:笑ってごまかした…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_120044")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor004,"Shy")

	--★★ギネヴィア★★:あの、ガウェイン、ラグネル<br>あのね、あのさ、お願いがあってぇそのですねえ
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A111_120046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "否定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:メシはやんねーぞ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_120047")

	change_face(Actor004,"Normal")

	--★★ギネヴィア★★:あ、もうお腹いっぱいなんで
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A111_120048")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:だよな。わかってた
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_120049")

	change_face(Actor004,"Shy")

	--★★ギネヴィア★★:………よびすてに、してくんないかなあ
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A111_120051")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:ギネヴィア…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_120053")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ギネヴィア★★:あなたじゃないわ
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A111_120054")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:だよな、わかってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_120055")

	change_face(Actor004,"Shy")

	--★★ギネヴィア★★:…それで、あの、あのぉ
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A111_120056")

	open_cutin(2,1)
	on_cutin(1,Actor002,"Smile")
	on_cutin(2,Actor003,"Smile")

	--★★ガウェイン／ラグネル★★:ギネヴィア！
	Talk(Actor008,"CHRNAME_GAWAIN_RAGNAR","speech","N","MA_01A111_120058")

-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
	close_cutin()
	change_face(Actor004,"Surprise")

	--★★ギネヴィア★★:………ガウェイン、ラグネル…！
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A111_120059")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "喜び")
-- ▲直接出力

	--★★エレイン★★:ギネヴィアさぁん…！！
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A111_120060")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ギネヴィア★★:ああ～～エレイン、こわかった～…！<br>こわかったよ～～～…！
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A111_120061")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力

	--★★エレイン★★:じゃ！おかわり取ってきますね！！
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A111_120062")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ギネヴィア★★:た、タンパクね、案外…！
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A111_120063")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
fadein(IMAGE_TIME_IN_IN)
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★エレイン★★:（私があなたに<br>勝手に感じたシンパシー）
	Talk(Actor006,"CHRNAME_ELAINE","mind","L","MA_01A111_120065")


	--★★エレイン★★:（泣き言ひとつ口にしないで<br>飲み込んで戦い続けて──）
	Talk(Actor006,"CHRNAME_ELAINE","mind","L","MA_01A111_120066")


	--★★エレイン★★:（…いいよね）
	Talk(Actor006,"CHRNAME_ELAINE","mind","L","MA_01A111_120068")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★エレイン★★:（言えないままで、いいよね）
	Talk(Actor006,"CHRNAME_ELAINE","mind","L","MA_01A111_120069")

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
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
