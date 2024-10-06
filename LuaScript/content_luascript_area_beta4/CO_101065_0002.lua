-- このluaスクリプトは、CO_101065_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-57.8,CharaPos112021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_508_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★キッス★★:さてさて、それじゃあ今日は
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010008")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:ノワールくんのエスコート力をしっかり見させてもらおうかしら♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010009")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:エ、エスコート力って…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_00010010")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")

	--★★キッス★★:ちゃあんとアタシのこと満足させてちょうだいね
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010011")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力

	--★★ノワール★★:満足って、どうすれば…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_00010012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:それを考えるのもエスコート力のひとつ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:じゃないと本番で失敗しちゃうわよ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010014")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:本番って…そんな相手いないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_00010015")

-- ▼直接出力
PlayPartVoice("キッス", "肯定3")
-- ▲直接出力

	--★★キッス★★:あら、そうなの？じゃあアタシ、立候補しちゃおうかしら♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_00010017")

-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力

	--★★キッス★★:ヤダ～、本気にしちゃった？冗談よ、冗談
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010018")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★キッス★★:今のラビットちゃんだとまだアタシの相手は無理ね～
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010019")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そ、そう…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_00010020")


	--★★ノワール★★:（告白してもいないのになんだか振られた気分だ…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101065_00010021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★キッス★★:というわけで、本番に向けた<br>予行練習、始めるわよ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010022")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:本気でやるのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_00010023")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力

	--★★キッス★★:それじゃあ…このマーケットにあるもので今、アタシが欲しいものってなんだと思う？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010024")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:キッスさんが欲しいものか…そうだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_00010025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101065_00010026","CO_101065_00010027","CO_101065_00010028")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:クッションとか…どうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_00010030")

-- ▼直接出力
PlayPartVoice("キッス", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★キッス★★:クッション？どうしてそう思ったの？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010031")

	change_face(Actor001,"Normal")

	--★★ノワール★★:いや…なんとなく疲れてそうだったから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_00010032")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:クッションとか柔らかいものでも抱いてゆっくり休みたいんじゃないかなと思ったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_00010033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:あら！アタシが疲れていることを見抜いたうえに気遣ってくれるなんて、さすがね
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010034")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:キッスさんとは何度も会ってるからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_00010035")

-- ▼直接出力
PlayPartVoice("キッス", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★キッス★★:でも…アタシ、そんなに疲れた顔してたかしら？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010036")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あっ、いや…えっと…そういうわけでは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_00010037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:ンフフ、かわいい♪そういうところもアタシ好みよ～
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010038")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★キッス★★:それじゃ、アタシに合いそうなクッションを選んでくれる？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010039")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、もちろん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_00010040")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:困った人…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_00010043")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("キッス", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★キッス★★:ええ～困った人ぉ～？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010044")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:よく言ってるじゃないか他人の困った顔を見るのが好きって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_00010045")

-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:確かにそれはそうなんだけどあくまでもアタシが困らせてこそなの
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010046")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★キッス★★:だから最初から困ってる人なんてこれっぽっちも興味ないわよ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010047")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そういうものなのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_00010048")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:そういうものなの♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010049")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:だから今、ちょっと困ってるラビットちゃん、なかなかイイ感じよ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010050")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ハハ…どうも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_00010051")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:普段酒場にいるんだしお酒なんてどうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_00010054")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:んーもちろんお酒は大好きだけど…
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010055")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:アタシを満足させられるようなお酒は高いわよ？す～っごくね
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010056")

	change_face(Actor002,"Normal")

	--★★キッス★★:ラビットちゃんのお小遣いで買えるかしら…？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010057")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:難しい、かも…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_00010058")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:だから、ラビットちゃんが大人になってたっくさんお金を稼げるようになったら
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010059")

-- ▼直接出力
PlayPartVoice("キッス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:美味しいお酒を買ってちょーだい♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010060")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ハ、ハイ…（いつの間にか俺が買う話になってる…？）
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_00010061")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor002,"キッス")
-- ▲直接出力
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
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
