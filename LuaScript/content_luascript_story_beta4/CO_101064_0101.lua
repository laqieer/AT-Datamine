-- このluaスクリプトは、CO_101064_0101.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110151_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110151_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110151_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110151_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_001)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115154)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401020","001","401020001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to  Std_Joy")

	--★★市民（中年女）★★:いつも本当にありがとうございます<br>司祭さま
	Talk(Actor004,"NPCNAME_0256","speech","N","CO_101064_01010002")


	--★★ノワール★★:ん？あれは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_01010003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★リアム★★:貴方の様子をたまに見てやって欲しいと<br>遠方に嫁いだ娘さんから頼まれていますからね
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_01010005")

	PlayAction(Actor003,"to  Std_Talk")

	--★★クラリス★★:お変わりないですか～？
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101064_01010006")


	--★★市民（中年女）★★:はい、おかげさまで
	Talk(Actor004,"NPCNAME_0256","speech","N","CO_101064_01010007")


	--★★ノワール★★:（リアム司祭とシスター・クラリスか）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101064_01010008")


	--★★市民（中年女）★★:司祭さまたちは他のお仕事もあるでしょう？<br>なのに、アタシなんかのために…
	Talk(Actor004,"NPCNAME_0256","speech","N","CO_101064_01010010")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★リアム★★:こんなご時世です<br>ひとは寄り添い合って生きていかねばなりません
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_01010011")

	change_face(Actor002,"Smile")

	--★★リアム★★:困ったことがあったら<br>いつでもお声がけください
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_01010012")


	--★★クラリス★★:リアムさま、わたしはこの方を<br>ご自宅まで送ってまいります
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101064_01010013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★リアム★★:お願いします、クラリス<br>私は別件を済ませてから大聖堂に戻ります
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_01010014")

	PlayAction(Actor001,"to Greet_one")

	--★★ノワール★★:こんにちは、リアムさん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_01010016")

	change_face(Actor002,"Surprise")

	--★★リアム★★:おや、ノワールさん<br>今、寮に戻られるところですか？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_01010017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ああ<br>リアムさんはここでなにを？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_01010018")

	change_face(Actor002,"Normal")

	--★★リアム★★:大聖堂にはさまざまな方が訪れます<br>祈りを捧げる方、過ちを告白する方…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_01010019")


	--★★リアム★★:日々の生活で困ったことがあったり<br>悩みを抱えている方もいらっしゃいますね
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_01010020")

	change_face(Actor002,"Smile")

	--★★リアム★★:私とクラリスはときどき<br>そんな方たちのお手伝いをしているのですよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_01010021")

	open_select_window_tag(Actor001,"Normal","CO_101064_01010023","CO_101064_01010024")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:司祭の仕事ってよく知らないけれど<br>そこまでやるもんなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_01010026")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★リアム★★:どうでしょうか。ほかの司祭の仕事を<br>気にしたことはあまりありませんから
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_01010027")

	change_face(Actor002,"Smile")

	--★★リアム★★:ですが、困っている方に寄り添うという考えは<br>司祭なら誰も持ち合わせていると思いますよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_01010028")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:そっか…立派だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_01010029")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…無償で？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_01010031")

	change_face(Actor002,"Anger")

	--★★リアム★★:…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_01010033")

	change_face(Actor001,"Sad")

	--★★ノワール★★:す、すまない<br>軽はずみな質問をしてしまって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_01010034")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to Greet_one")
	change_face(Actor002,"Normal")

	--★★リアム★★:それでは、私はこれで<br>他の方からも頼まれごとをしておりますので
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_01010036")

	PlayAction(Actor001,"to Greet_one")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、それじゃまた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_01010037")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…あっ！そういえば俺もディナタンから<br>帰りがけに飲み物を買ってくるよう頼まれてた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_01010039")

	change_face(Actor001,"Normal")

	--★★ノワール★★:マーケットか酒場に行ってくるか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_01010040")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_リアム_ランクアップ1_2")
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
	load_area_scene_preload(115154)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401020","001","401020001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
