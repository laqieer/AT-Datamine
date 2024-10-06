-- このluaスクリプトは、CO_101011_1002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110041_02","110041_02_h")
Include("content_adv_advsmall_110041_02","Template110041_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110041_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110041_02,CameraPos110041_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110041_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110041_02,CameraPos110041_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110041_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110041_02,CameraPos110041_02_003)
	InitializeTemplateRandomCamera110041_02()
	InitializeTemplate110041_02()
-- ▼直接出力
Hide(Actor003)
set_pos(Actor003, {-2.59, 0, -6.42})
set_enable_auto_lookat(Actor002,false)
-- ▲直接出力
-- ▼直接出力
load_image("104000070", "content_still_10400007_image", "104000070_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("103050230","content_still_10305023_image","103050230_StillImage")
set_pos(Actor001,{1.2,0,-1.8})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:…ここか<br>まあ、気分転換にはピッタリかもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020002")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:にししっ♪<br>ノワールもわかってきたじゃない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020003")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
se_play("SE_ADV_MA_01B900_13_Wind_Blow")
wait_time(3.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
wait_time(0.5)
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:ありがとね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020005")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,115,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0057")
-- ▲直接出力

	--★★ノワール★★:ん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020006")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ガラス玉探し、ずっと付き合ってくれて
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020007")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:わたしとお姉ちゃんの<br>問題に付き合わせちゃって…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020008")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001,0.5)
keep_ik_lookat(Actor002,Actor001,"J_Head")
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0037")
-- ▲直接出力

	--★★ギネヴィア★★:ごめんなさい！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020010")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101011_10020012","CO_101011_10020013","CO_101011_10020014")
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
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:謝る必要なんてないよ<br>俺とキミはマスターとキラーズの関係だろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:キミの問題は俺の問題なんだ<br>キミが悲しいことは、俺だって悲しい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020017")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ノワール…ありがとう
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020018")

	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:素敵なマスターと出会えてよかった
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020019")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0057")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ん、よく聞こえなかった<br>なんて言ったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020020")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:聞こえてるくせに！<br>いじわる！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020021")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera001)
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺のことは気にしないでいいよ<br>それより、ふたりが仲直りできてよかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020023")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺とＧＳしたとしても<br>キミとギネマウアさんが姉妹なことは変わらない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020024")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:姉妹…家族はいつまでも仲良く<br>一緒に笑い合える関係でいてほしい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020025")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ノワール…！<br>ありがとう、お姉ちゃんも喜ぶよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020026")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0058")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ほんと<br>キミにはいつも振り回される
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020028")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:ごめん…ごめんね…<br>もうノワールに迷惑かけないようにするから…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020029")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0049")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020030")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺はそんなキミに振り回されたくて<br>あのとき手を取ったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020031")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:だからこれからも<br>思う存分、俺を振り回してくれていいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020032")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:うん…！そうする！<br>これまで以上に振り回したげる！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020033")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:（しまった…調子に乗りすぎたか…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101011_10020034")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
setup_small_camera_start()
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:でもさ<br>キミのお父さん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020036")


	--★★ノワール★★:どうしてガラス玉なんて<br>プレゼントしたんだろうな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020037")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:当時のキミもギネマウアさんも<br>あれが宝石じゃないってわかったろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020038")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_end()
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ビンボーで<br>それしか買えなかったとか？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020040")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera001)
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いくらなんでも<br>それはないんじゃないか～？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020041")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera003)
turn_chara(Actor001, 115.443,0)
turn_chara(Actor002,85.697,0)
Appear(Actor003)
character_in_move_walk(Actor003,CharaPos003,2,0)
turn_chara(Actor003, 30,0.5)
　wait_time(1.0)
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力

	--★★ギネマウア★★:ありえない話じゃないかもしれませんよ<br>お父様だったら
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_10020043")

-- ▼直接出力
setup_small_camera_start(Camera002)
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor003,0.5)
keep_ik_lookat(Actor002,Actor003,"J_Head")
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:だよねだよね！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020044")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ギネマウア★★:ギネヴィア<br>ガラス玉を少し貸してくれる？
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_10020045")

-- ▼直接出力
CloseTalkWindow()
turn_lookat(Actor002,Actor003,0.5)
keep_ik_lookat(Actor002,Actor003,"J_Head")
wait_time(0.5)
PlayActionDirect(Actor002,"to LookFor")
wait_time(1)
PlayActionDirect(Actor002,"to Show")
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to EatIdle")
PlayActionDirect(Actor002,"to Std_Loop")
SkipDefaultMotion(Actor003)
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ギネマウア★★:でも、こうやってガラス玉に透かして見ると<br>光の屈折の影響もあって
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_10020047")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ギネマウア★★:いつでもあなたが<br>キラキラとした笑顔でいるように見える
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_10020049")

-- ▼直接出力
PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力

	--★★ギネマウア★★:つまり<br>あなたの笑顔がお父様にとって一番の宝石だった
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_10020050")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネマウア★★:…のではないかしら
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_10020051")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:え～？それだと<br>ちょっとパパかっこよすぎない？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020053")

-- ▼直接出力
PlayPartVoice("ギネマウア", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネマウア★★:あら？<br>お父様はかっこよかったわよ？
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_10020054")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★ギネマウア★★:ずっと昔、スマートだった頃はね<br>…肖像画でしか見たことないけれど
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_10020055")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:じゃあ、今日はそういうことにしておこうかな<br>ちょうどいいし
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020057")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ちょうどいい？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020058")

-- ▼直接出力
setup_small_camera_start()
CloseTalkWindow()
turn_lookat(Actor002,Actor001,0.5)
keep_ik_lookat(Actor002,Actor001,"J_Head")
wait_time(0.5)
PlayActionDirect(Actor002,"to LookFor")
wait_time(1)
PlayActionDirect(Actor002,"to Show")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…はい、これ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020059")

-- ▼直接出力
ShowImageItem(104000070)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:このあいだの<br>玉座にいっぱいあったガラス玉？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020061")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:うん、そう。あそこに置いておくのもなんだし<br>持って帰って来ちゃった
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020062")

-- ▼直接出力
CloseTalkWindow()
HideImageItem()
-- ▲直接出力

	--★★ギネヴィア★★:でね<br>それにはわたしが魔法をかけといたから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020063")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:あなたに幸せを運んでくれる魔法をね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020064")

	open_select_window_tag(Actor001,"Normal","CO_101011_10020066","CO_101011_10020067")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0053")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ありがとう<br>大切にするよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020069")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ぜったいよ？<br>ぜったい、大切にしてよ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020070")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:なにかケースにしまって<br>なくさないようにしてね？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020071")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:もちろん<br>ずっと大事にするから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020072")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ふたりの話を聞いて羨ましくなっちゃって<br>俺も欲しいなって思ってたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020074")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:お揃いだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020075")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:うん<br>ずっと大事にしてね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020076")

	goto Block2end

::Block2end::
-- ▼直接出力
change_face(Actor003,"Normal")
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor003,1)
keep_ik_lookat(Actor002,Actor003,"J_Head")
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:お姉ちゃんにも同じのあるんだ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020078")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:どうしたの？<br>お姉ちゃん、受け取ってくれないの？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020080")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネマウア", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Shy")

	--★★ギネマウア★★:実は…私もふたりに<br>同じものを贈ろうと考えていて…
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_10020081")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ギネマウアさんも<br>あのガラス玉を持って帰って来てたのか…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020083")


	--★★ギネマウア★★:いっぱいありましたし…
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_10020084")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:やめてよ、もう！<br>姉妹そろってビンボくさくて恥ずかしい…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020085")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ビンボくさくなんかないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020087")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,85.697,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★ノワール★★:大事な家族が中に見える<br>他では絶対手に入らない、素敵な宝石だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020088")

-- ▼直接出力
PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネマウア★★:…そうですね
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_10020089")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ギネマウア★★:…これでずっと一緒よ
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_10020091")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:うん<br>わたしたちみんな、ずーっと一緒
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020092")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020093")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Sad02")
SkipDefaultMotion(Actor002)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:…あれっ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020095")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0021")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:泣かないって…約束したのにな
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020096")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いいんじゃないか？<br>泣いたって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020097")


	--★★ノワール★★:俺の周りはさ。強い信念をもって<br>ひたむきに突き進む人間ばっかりだった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020099")


	--★★ノワール★★:もちろんそれは尊敬できることで<br>俺もみんなに負けないようにしていたつもりだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020101")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:でも、キミに出会って、ワガママに振る舞ったり<br>弱い部分を見せることもアリなんだって知った
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020102")

-- ▼直接出力
setup_small_camera_end()
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001,0.5)
keep_ik_lookat(Actor002,Actor001,"J_Head")
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力

	--★★ギネヴィア★★:…それ、褒めてる？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_10020103")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:褒めてる、褒めてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020104")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:お飾りで終わらず<br>派手な飾りの似合う存在になろうと頑張る
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020105")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そんな姿に憧れた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020106")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺はまだ<br>金色のコートが似合う男にはなれていない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020107")


	--★★ノワール★★:だからそのときが来るまで<br>俺の隣で見ていてほしいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_10020109")

-- ▼直接出力
CloseTalkWindow()
show_image("103050230", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) 
set_scale_image(0.7,0.7)
 wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
setup_small_camera_end()
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:見ててあげるわ<br>ずっとずっと未来まで
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","CO_101011_10020111")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力

	--★★ギネヴィア★★:お姉ちゃんと一緒に、ね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","CO_101011_10020112")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("ギネヴィア_コミュランク", "ギネヴィア_親密度")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("104000070", "content_still_10400007_image", "104000070_StillImage")
load_image_preload("103050230","content_still_10305023_image","103050230_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110041_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
