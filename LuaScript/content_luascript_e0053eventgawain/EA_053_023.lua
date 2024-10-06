-- このluaスクリプトは、EA_053_023.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor004,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
set_pos(Actor003,{0.706, 0, 7.33})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
turn_lookat(Actor004,Actor001,0)
keep_ik_lookat(Actor004,Actor001,"J_Head")
lookat_weight(Actor004,0.5,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101013","004","101013004","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401020","001","401020001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("市民中年_女1","0040")
-- ▲直接出力

	--★★おばあさん★★:ガウェイン。来てくれてありがとう<br>忙しいのに悪いねぇ
	Talk(Actor004,"NPCNAME_0255","speech","L","EA_053_0230002")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0050")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガウェイン★★:いいっていいって<br>それで、頼みって？
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230003")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("市民中年_女1","0007")
-- ▲直接出力

	--★★おばあさん★★:そうそう、頼みってのはほかでもない…<br>あそこの棚の上の荷物を取ってほしいんだよ
	Talk(Actor004,"NPCNAME_0255","speech","L","EA_053_0230004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0028")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ガウェイン★★:棚の上？
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230005")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★おばあさん★★:ほら、あたしじゃ手が届かなくてさ
	Talk(Actor004,"NPCNAME_0255","speech","L","EA_053_0230006")


	--★★おばあさん★★:かといって今の時期はみんな忙しいから<br>ばあさんの頼みなんて誰も聞いてくれないだろ？
	Talk(Actor004,"NPCNAME_0255","speech","L","EA_053_0230007")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0034")
-- ▲直接出力

	--★★ガウェイン★★:そんなことないと思うけど…
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230008")

-- ▼直接出力
PlayPartVoiceDirect("市民中年_女1","0042")
-- ▲直接出力

	--★★おばあさん★★:頼むよ、ガウェインが頼りなんだ～
	Talk(Actor004,"NPCNAME_0255","speech","L","EA_053_0230009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0009")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガウェイン★★:わかったよ、ばあちゃん！<br>ちょっと待ってな
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230010")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
setup_small_camera_end()
setup_small_camera_start(Camera001)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0010")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガウェイン★★:ほら、ばあちゃん
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230013")

-- ▼直接出力
setup_small_camera_end(Camera001)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("市民中年_女1","0036")
-- ▲直接出力

	--★★おばあさん★★:ああ、ありがとうねぇ<br>ほんと、ガウェインは頼りになるよ
	Talk(Actor004,"NPCNAME_0255","speech","L","EA_053_0230014")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor004)
setup_small_camera_start(Camera001)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ガウェイン★★:…ふぅ
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230016")

-- ▼直接出力
 --EntryWalk(Actor002,Camera002,EntryData112021_01_05,CameraAssetBundleName112021_01,CameraPos112021_01_105)
local actor = Actor002
local exCamera = Camera002
local eeTable = EntryData112021_01_05
local assetBundleName = CameraAssetBundleName112021_01
local assetName = CameraPos112021_01_105
local eeCamera = eeTable[1]
local startPos = {-3.02, 0, 0.4}
local goalPos = eeTable[3]  
local CameraTime1 = 1
local MoveTime = eeTable[6]

local active = is_active(actor)

on_active(actor)
set_pos(actor,startPos)
turn_lookat_position(actor,goalPos[1],goalPos[2],goalPos[3],0) --向きを行先に合わせる

-- 俯瞰
on_camera(RndCamera090)

if active == false then
    wait_time(0.03)	--ポーズが決まるのを待つ
end

exCamera.InitializeOffset()
eeCamera.CopyOffset(exCamera)
load_exclusive_camera(eeCamera ,assetBundleName, assetName, actor)

--キャラを移動させる
PlayActionDirect(actor,"to Wlk")
slidemove(actor, goalPos[1],goalPos[2],goalPos[3] ,MoveTime)

wait_time(CameraTime1)

on_camera(eeCamera)

while eeCamera.IsPositionAnimationPlayng() do
    coroutine.yield()
end

exCamera.SetSkipOffset()

if manager ~= nil then
    DontChangeRandomCamera(false)
    manager.CloseupUpExclusiveCamera(actor) -- キャラカメラに変更
end

PlayActionDirect(actor,"to Std_Loop")       --　モーションを基本立ちに設定して
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0004")
-- ▲直接出力

	--★★ノワール★★:お疲れ様、ガウェイン
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0230018")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガウェイン★★:！ノワール！？<br>お前、なんでここに
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230019")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ノワール★★:たまたまガウェインを見かけたから<br>声をかけようと思って
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0230020")


	--★★ノワール★★:そしたらなんかすごく忙しそうで<br>声をかけるタイミングを掴み損ねてさ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0230021")

	change_face(Actor001,"Normal")

	--★★ガウェイン★★:そ、そうか…
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EA_053_0230024","EA_053_0230025")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0002")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ガウェイン★★:ノワールはなにしてたんだ？
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230028")

	change_face(Actor002,"Normal")

	--★★ノワール★★:特になにも<br>ただフラフラしてた
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0230029")

	change_face(Actor001,"Normal")

	--★★ガウェイン★★:フラフラ
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230030")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:なにをしていいかわからなくてさ<br>こういう時間、過ごしたことないから
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0230031")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ガウェイン★★:気にせず声かけてくれりゃいいのに
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230034")

	change_face(Actor002,"Normal")

	--★★ノワール★★:そう言われても…声をかけようとした傍から<br>誰かに呼ばれてどっかいっちゃってたしな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0230035")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ノワール★★:ガウェインは皆に頼られてるんだなぁって<br>微笑ましく見てたよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0230036")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0010")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガウェイン★★:な、なんか照れるな…
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230037")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0002")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ノワール★★:お前、いい奴だな<br>皆の頼みごとを一手に引き受けてさ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0230039")


	--★★ノワール★★:五月祭に向けてアーサーから<br>頼まれてることもたくさんあるってのに…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0230040")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガウェイン★★:そう言ってもらえるのはありがたいけどさ<br>でも、そんなんじゃねーんだよ
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0230042")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0019")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガウェイン★★:まず俺はアーサー様の頼みとあらば<br>なんであろうと全力で応える
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230043")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ガウェイン★★:それはもちろんそうだ<br>なんせアーサー様の頼みだからな！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230044")


	--★★ガウェイン★★:そのうえで、街の皆が困ってたら力になる<br>誰かが呼んだらすぐに駆けつける
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230045")

	change_face(Actor001,"Normal")

	--★★ガウェイン★★:ラグネルの出し物の様子も見に行けねーけど<br>ヒーローってのはそういうもんだ、しかたねぇ
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230046")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★ノワール★★:（そうかな…？）
	Talk(Actor002,"CHRNAME_NOIR","mind","L","EA_053_0230047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガウェイン★★:だって俺はこの街のヒーローでありたいから…
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230048")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガウェイン★★:――そう、ヒーローでありたいんだよ、俺は！！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230049")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ノワール★★:あ、ああ。そうだな<br>皆も知ってると思うけど
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0230051")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0055")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ガウェイン★★:そうか！？けどなんか最近の感じって<br>ちょっと違うんだよなあ！！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230052")


	--★★ガウェイン★★:ガウェインは気のいい奴だから<br>頼めば何でもやってくれるよ～…的な！？
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230053")

	change_face(Actor001,"Anger")

	--★★ガウェイン★★:そういう感じがするっていうかさあ！<br>そんな風潮にはノーと言いたい、俺は！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230054")

	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0016")
-- ▲直接出力

	--★★ガウェイン★★:俺はヒーローであって<br>何でも屋じゃねーっての！！！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230055")

	change_face(Actor001,"Pain")

	--★★ガウェイン★★:はー…はー…
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230056")

	change_face(Actor002,"Sad")

	--★★ノワール★★:（…なんか色々たまってるみたいだ）
	Talk(Actor002,"CHRNAME_NOIR","mind","L","EA_053_0230057")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0037")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガウェイン★★:…わりぃ<br>なんか俺、ちょっと疲れてるのかも
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230058")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:働きすぎだよ<br>少し休んだほうがいい
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0230059")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0025")
-- ▲直接出力

	--★★ガウェイン★★:そうするか…
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230060")

-- ▼直接出力
local gopos = {0.706, 0, 2.252}
CloseTalkWindow()
setup_small_camera_start()
Appear(Actor003)
turn_lookat_position(Actor003, gopos, 0)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003, gopos, 2.5)
wait_time(2.5)
setup_small_camera_end()
setup_small_camera_start(Camera003)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.5)
-- ▲直接出力

	--★★リオネス★★:あ！いたいた！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","EA_053_0230062")

-- ▼直接出力
keep_ik_lookat(Actor001,Actor003,"J_Head")
turn_lookat(Actor001,Actor003,0)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor003,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101033_sp_0003_1")
-- ▲直接出力

	--★★リオネス★★:ガウェイン、ちょっといいか？<br>ヒーローに頼みたいことがあるんだ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","EA_053_0230063")

-- ▼直接出力
setup_small_camera_end(Camera003)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor001, true)
PlayPartVoiceDirect("ガウェイン","0009")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガウェイン★★:よし、分かった。すぐ行くぜ！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230064")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,44,0.2)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.2)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:え！？行くのか！？<br>休むって言ったばかりなのに！？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0230065")

	change_face(Actor002,"Normal")

	--★★ノワール★★:かなり疲れてるみたいだし<br>休んだ方がいいって…！
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0230066")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0051")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ガウェイン★★:けど、ヒーローに頼みがあるっていうから
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230067")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:はぁ…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0230068")

	change_face(Actor002,"Normal")

	--★★ノワール★★:わかった。じゃあ俺も行くよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0230069")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガウェイン★★:ノワールも？
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230070")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力

	--★★ノワール★★:ヒーローの助手ってことで<br>なにか手伝えることがあるかもしれないだろ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0230071")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0036")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガウェイン★★:ノワール…ありがとうな
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0230072")

	change_face(Actor003,"Smile")

	--★★リオネス★★:それじゃ、行こう！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","EA_053_0230073")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101013","004","101013004","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401020","001","401020001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
