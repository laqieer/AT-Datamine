-- このluaスクリプトは、CO_101039_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",60,CharaPos114011_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_001)
	Camera002 = SetTemplate("Actor002",185,CharaPos114011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_003)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:うーん！やっぱりロンディニウムはいいよね！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_00010008")


	--★★フレン★★:ローマの風を浴びて心が解放されていく気がするよ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_00010009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:フレンはローマの出身だっけ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_00010010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:そうだよ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_00010011")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★フレン★★:ノワールくんもログレスとは違う場所の出身だったよね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_00010012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_00010013")

	change_face(Actor002,"Smile")

	--★★フレン★★:じゃあ、私とノワールくんは
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_00010014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力

	--★★フレン★★:故郷に錦を飾るために<br>日々切磋琢磨する同志ってわけだね！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_00010015")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ちょっと大げさな気もするけど<br>まあ、言われてみればそうかもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_00010016")

	open_select_window_tag(Actor001,"Normal","CO_101039_00010017","CO_101039_00010018","CO_101039_00010019")
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
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:故郷に錦を飾るんだったらこんなところでノンビリしてられないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_00010021")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:急いで学園に帰って勉学に励まないと！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_00010022")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("フレン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:えーっ！？今、来たばかりなのに！？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_00010023")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:はは！冗談だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_00010024")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("フレン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:もう！ノワールくんのイジワル！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_00010025")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:フレンの故郷ってロンディニウムに似てるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_00010028")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★フレン★★:ううん私が生まれたのはもっとずっと田舎だった
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_00010029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★フレン★★:でも長閑でとってもいい所だったよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_00010030")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("フレン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:もうしばらく帰ってないから今、どうなってるかはわからないけどね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_00010031")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…ごめん、悪いこと聞いたか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_00010032")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:ううん、気にしないで！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_00010033")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★フレン★★:ローラが傍にいてくれるなら私はどこにいても寂しくないから！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_00010034")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★フレン★★:でも、ときどきはローマに戻ってみるのもいいかな
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_00010035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:ノワールくんがローマに興味あるなら今度案内してあげよっか？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_00010036")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それ、いいな！ぜひお願いしたい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_00010037")

	change_face(Actor002,"Smile")

	--★★フレン★★:でしょ？どこに連れていくのがいいかなあ…
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_00010038")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:今度、ローラに相談してみよっと！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_00010039")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:フレンの話を聞いてたら俺も故郷が懐かしくなってきたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_00010042")

	change_face(Actor001,"Normal")

	--★★ノワール★★:今度、久々に帰ってみようかな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_00010043")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★フレン★★:ノワールくんの故郷ってどんな所なの？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_00010044")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:えっと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_00010045")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ログレスからすごく離れた田舎の村で近くに綺麗な湖があるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_00010046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:えー、いいなー！私も見てみたい！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_00010047")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:機会があったら案内するよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_00010048")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor002,"フレン")
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
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
