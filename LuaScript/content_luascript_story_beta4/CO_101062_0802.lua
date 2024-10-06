-- このluaスクリプトは、CO_101062_0802.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_03","112021_03_h")
Include("content_adv_advsmall_112021_03","Template112021_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_001)
	InitializeTemplateRandomCamera112021_03()
	InitializeTemplate112021_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("401011","001","401011001")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:その手紙、また店からの業務報告か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_08020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:はい。でも…今回はそれだけじゃなくて
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08020003")


	--★★マルイル★★:………祖父の容体が、悪化したって
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どういうことだ<br>爺さん、具合が悪いのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_08020005")

-- ▼直接出力
PlayPartVoice("マルイル", "悩む")
-- ▲直接出力

	--★★マルイル★★:…祖父は長年難病を患っていたんです<br>ぼくはずっと、その難病の治療薬を探してました
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08020006")


	--★★マルイル★★:旅商人をしていたのもそのためです<br>でも、世界中を回っても見つからなくて…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08020007")

-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:バルバロイの遺骸から生成できるって話だから<br>危険な場所にも行けるように鍛えたんですけど
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08020008")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("マルイル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:やっぱりバルバロイはぼくには倒せなくて…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08020009")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それで傭兵を頼んだのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_08020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:お客様の求める希少素材を求めるため<br>というのがもちろん第一でしたけどね…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08020011")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★市民（男）★★:うまくいけば普通の人間でも<br>バルバロイを倒せるようになるかもしれない
	Talk(Actor003,"NPCNAME_0271","simple","L","CO_101062_08020013")

-- ▼直接出力
wait_time(0.5)
 --DontChangeRandomCamera(false)
 --manager.CloseupUpExclusiveCamera(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…！なあ、もしかして<br>このあいだの研究者が言ってた薬があれば…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_08020014")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルイル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:え…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08020015")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:マルイルがバルバロイを倒して<br>治療薬を手にすることもできるんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_08020016")

-- ▼直接出力
PlayPartVoice("マルイル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:ぼくも、その可能性は考えました<br>でも、そんなに上手くいくはずが…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08020017")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★マルイル★★:それに、そうだとしても<br>あの人がどこにいるかもわからないですし…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08020018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101062_08020020","CO_101062_08020021")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:だったら/あの人をさがしにいけばいいだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_08020023")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺も手伝う。人さがしなら/傭兵の頃に何度もやったことがあるからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_08020024")

-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:ノワールさんのいた傭兵団って…/なんでも屋みたいですね
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08020025")

-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そういうわけじゃないけど…/俺の前の団長が、情に厚い人だったから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_08020026")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:…そっくりですね/ノワールさんとその人
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08020027")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:だからって諦めるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_08020029")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:ちょっとでも可能性があるのに/諦めるなんて、あんたらしくないぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_08020030")

	change_face(Actor002,"Surprise")

	--★★マルイル★★:…ぼくらしく、ない…！？
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08020031")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "納得")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マルイル★★:そう、ですよね…！/…ぼく、さがしにいきます！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08020033")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_マルイル_ランクアップ8_3")
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
	InitializeCharacter_3D_Preload("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("401011","001","401011001")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
