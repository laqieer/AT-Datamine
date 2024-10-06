-- このluaスクリプトは、CO_101013_0403.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_03","112021_03_h")
Include("content_adv_advsmall_112021_03","Template112021_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_001)
	InitializeTemplateRandomCamera112021_03()
	InitializeTemplate112021_03()
-- ▼直接出力
lookat_weight(Actor001,0.45, 0.1, 0.7, 0.3)
keep_ik_lookat(Actor001,Actor002, "J_Head")
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor002,0.4, 0.1, 0.7, 0.3)
keep_ik_lookat(Actor002,Actor001, "J_Head")
-- ▲直接出力
-- ▼直接出力
load_image("104000060", "content_still_10400006_image", "104000060_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:ちょっと知り合いの何人かに聞いてきてみるわ<br>ノワールはここで待っててくれていいぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04030002")

-- ▼直接出力
setup_small_camera_start(Camera001)
Hide(Actor002)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04030003")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003, "J_Head",0.8)
Camera002 = setup_small_camera_resetting(Actor002,CharaPos003,CameraPos003)
wait_time(0.4)
-- ▲直接出力

	--★★ノワール★★:ここは<br>前にギネヴィアに連れてこられた宝石屋か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04030005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民中年_男2", "挨拶")
-- ▲直接出力

	--★★市民（中年男）★★:いらっしゃいませ<br>今は琥珀がお安くなってますよ
	Talk(Actor003,"NPCNAME_0157","speech","N","CO_101013_04030006")

-- ▼直接出力
set_pos(Actor002, {3.098,0,3.25})
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:琥珀？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04030007")

-- ▼直接出力
PlayPartVoice("市民中年_男2", "肯定")
-- ▲直接出力

	--★★市民（中年男）★★:厳密に言うと、琥珀は宝石ではないんですがね<br>長い時間をかけて固まった樹脂です
	Talk(Actor003,"NPCNAME_0157","speech","N","CO_101013_04030008")


	--★★市民（中年男）★★:植物や動物、虫が閉じ込められたものは<br>装飾品や調度品として人気があります
	Talk(Actor003,"NPCNAME_0157","speech","N","CO_101013_04030009")

-- ▼直接出力
setup_small_camera_start(Camera001)
 --Appear(Actor002)
wait_time(WAIT_TIME_SHORT)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へえ～植物や動物、虫か<br>…ん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04030010")

-- ▼直接出力
 --setup_small_camera_end(Camera001)
CloseTalkWindow()
setup_small_camera_start()
IN_WALK(Actor002,CharaPos112021_03_003)
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor002,-110,0.5)
PlayActionDirect(Actor002,"to  Std_Sad02")
PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:悪い、ノワール<br>知り合いをあたってみたけど全滅だった…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04030012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ガウェイン、いいところに来た！<br>キンイロチョウ、捕まえられるかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04030013")


	--★★ノワール★★:捕まえられるって表現が正しいかわからないけど<br>鑑賞用としてはベストに近いぞ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04030014")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:待て待て、なに興奮してんだお前<br>話が見えねーぞ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04030015")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:これ、化石の一種で<br>琥珀っていうんだけどさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04030016")


	--★★ノワール★★:中に虫が入っていることもあるんだって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04030018")

-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力

	--★★ガウェイン★★:…だから？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04030019")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:キンイロチョウが入った<br>琥珀があるかもしれないってことだよ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04030020")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:おおーっ、そうか！それなら<br>綺麗な状態のキンイロチョウを見られるな！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04030021")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:でもよ。そんな都合よく<br>キンイロチョウが入った琥珀なんてねーだろ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04030023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("市民中年_男2", "笑い")
-- ▲直接出力

	--★★市民（中年男）★★:ございますよ
	Talk(Actor003,"NPCNAME_0157","speech","N","CO_101013_04030024")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:そうだよな<br>あるわけな…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04030025")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:あるのか！？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04030027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:こんなにあっさり見つかるなんて<br>驚きだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04030028")

-- ▼直接出力
PlayPartVoice("市民中年_男2", "肯定")
-- ▲直接出力

	--★★市民（中年男）★★:少々お待ちください
	Talk(Actor003,"NPCNAME_0157","speech","N","CO_101013_04030029")

-- ▼直接出力
ShowImageItem("104000060")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★市民（中年男）★★:こちらですね<br>どうぞご覧になってください
	Talk(Actor003,"NPCNAME_0157","speech","N","CO_101013_04030031")

-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力

	--★★ガウェイン★★:本当にキンイロチョウが入ってる…！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04030033")

-- ▼直接出力
HideImageItem()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:あのさ<br>これっていくらかな？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04030034")

-- ▼直接出力
PlayPartVoice("市民中年_男2", "肯定2")
-- ▲直接出力

	--★★市民（中年男）★★:キンイロチョウは希少種ですからね<br>他の琥珀と比べても少々お高いですよ
	Talk(Actor003,"NPCNAME_0157","speech","N","CO_101013_04030035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガウェイン★★:…どのくらい？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04030036")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor003,"to  Std_Talk")
wait_time(WAIT_TIME_SHORT)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:そ、そんなにすんの！？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04030038")

	open_select_window_tag(Actor001,"Normal","CO_101013_04030040","CO_101013_04030041","CO_101013_04030042")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:一応言っておくけど…俺は貸せないからな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04030044")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ディナタンから貰ってる小遣いは<br>毎月ほんのちょっとなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04030045")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:貸してくれって言うつもりはねーけど<br>お前、お小遣い制だったのか…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04030046")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どうにかして稼ぐか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04030048")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:何ヶ月か頑張って働けば買えるかも<br>俺も手伝うからさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04030049")

-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:お前らしい堅実な考えかただな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04030050")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺たちの小遣いじゃ買えないよ<br>諦めたほうがいいんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04030052")

-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガウェイン★★:「キンイロチョウは捕まえられなかった<br>諦めてくれ」ってトムに言うのか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04030053")

	change_face(Actor002,"Sad")

	--★★ガウェイン★★:俺にはそんな酷いことできねーよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04030054")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:うーん頑張ってカネを用意するしかねーか
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04030056")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003, "J_Head",0.8)
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力

	--★★ガウェイン★★:店員さん、ありがとう<br>今日は手持ちが足りねーから、また来るよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04030057")

-- ▼直接出力
PlayPartVoice("市民中年_男2", "肯定")
-- ▲直接出力

	--★★市民（中年男）★★:はい、お待ちしております
	Talk(Actor003,"NPCNAME_0157","speech","N","CO_101013_04030058")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001, "J_Head",0.8)
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:ノワール<br>えっと、あのさ…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04030060")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:わかってる、協力するよ<br>元傭兵に任せてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04030061")

-- ▼直接出力
local trustParam = set_communication_rankup("ガウェイン_コミュランク", "ガウェイン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("104000060", "content_still_10400006_image", "104000060_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
