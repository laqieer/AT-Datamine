-- このluaスクリプトは、CO_101064_0903.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_03","112041_03_h")
Include("content_adv_advsmall_112041_03","Template112041_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112041_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112041_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos112041_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPos112041_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_018_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_005)
	InitializeTemplateRandomCamera112041_03()
	InitializeTemplate112041_03()
-- ▼直接出力
sakabin = setup_prop_object(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
on_parent(sakabin ,Actor006, "Loc_weapon_constrint_R", sakabin_offset2 )
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401021","001","401021001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401027","001","401027001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Surprise")

	--★★市民（男）★★:リアム！？
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_09030002")

	PlayAction(Actor002,"to  Std_Talk")

	--★★リアム★★:やはりここでしたか<br>昔から貴方たちは酒盛りが好きでしたからね
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09030003")

	PlayAction(Actor004,"to Greet_one")

	--★★市民（中年男）②★★:うわ、本当にリアムじゃん！生きてたのかよ！
	Talk(Actor004,"NPCNAME_0252","speech","N","CO_101064_09030005")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★市民（中年男）★★:思ったより元気そうだな<br>なんだその服、似合ってねぇぞ
	Talk(Actor005,"NPCNAME_0251","speech","N","CO_101064_09030006")

	change_face(Actor002,"Smile")

	--★★リアム★★:元気そうで何よりです<br>市民（中年男）②、市民（中年男）
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09030007")

	PlayAction(Actor003,"to  Std_Worry")
	change_face(Actor003,"Normal")

	--★★市民（男）★★:けっ<br>ここは偉い司祭サマが来ていい場所じゃねえぜ？
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_09030009")


	--★★市民（男）★★:カミサマに雷落とされるんじゃねぇの？
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_09030010")


	--★★リアム★★:主は貴方が思われているより寛容ですよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09030011")

	PlayAction(Actor004,"to  Std_Talk")

	--★★市民（中年男）②★★:それで？<br>ここへなにしに来たんだよ？
	Talk(Actor004,"NPCNAME_0252","speech","N","CO_101064_09030012")


	--★★市民（中年男）★★:あとよ、そっちの小僧はなんだ？
	Talk(Actor005,"NPCNAME_0251","speech","N","CO_101064_09030013")

	change_face(Actor002,"Normal")

	--★★リアム★★:私の友人です。これでも円卓の騎士ですからね<br>甘く見ないほうが身のためですよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09030015")

	open_select_window_tag(Actor001,"Normal","CO_101064_09030017","CO_101064_09030018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Smile")

	--★★ノワール★★:どうも、はじめまして<br>ノワールって言います
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_09030020")

	PlayAction(Actor004,"to  Std_Surp")
	change_face(Actor004,"Normal")

	--★★市民（中年男）②★★:円卓の騎士？こいつが？
	Talk(Actor004,"NPCNAME_0252","speech","N","CO_101064_09030021")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★市民（男）★★:たぶん本当だ。こいつ、この街じゃ有名人だぞ<br>あちこちで噂を聞いた
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_09030022")

	change_face(Actor003,"Normal")

	--★★市民（男）★★:おそらく俺たちの数倍は強え
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_09030023")

	PlayAction(Actor004,"to  Std_Sad01")
	change_face(Actor004,"Normal")

	--★★市民（中年男）②★★:すみませんでした
	Talk(Actor004,"NPCNAME_0252","speech","N","CO_101064_09030025")

	change_face(Actor002,"Sad")

	--★★リアム★★:やれやれ<br>相変わらずゲンキンですね、ふたりは…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09030027")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Anger")

	--★★ノワール★★:おうおうおう！俺の名はノワール！<br>ナメたクチ利きやがったら痛ぇ目に遭わせんぞ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_09030029")

	change_face(Actor002,"Normal")

	--★★リアム★★:ノワールさん。彼らも昔はなかなかのものでした<br>あまり調子に乗らないほうが身のためですよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09030030")

	change_face(Actor001,"Sad")

	--★★ノワール★★:すみません…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_09030031")

	goto Block1end

::Block1end::
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★市民（男）★★:で、リアム。あらためて聞くがよ<br>なんでここに来たんだ？
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_09030033")


	--★★市民（中年男）★★:気が変わったのか？
	Talk(Actor005,"NPCNAME_0251","speech","N","CO_101064_09030034")

	change_face(Actor002,"Normal")

	--★★リアム★★:それは半分正解で<br>半分間違いといえます
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09030035")

	change_face(Actor004,"Normal")

	--★★市民（中年男）②★★:どういうこった？
	Talk(Actor004,"NPCNAME_0252","speech","N","CO_101064_09030036")


	--★★リアム★★:黒牙団と名乗る輩たちが<br>この街の人々に危害を加えています
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09030037")

	PlayAction(Actor002,"to  Std_No")

	--★★リアム★★:司祭としてそれを許すわけにはいきません
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09030038")


	--★★市民（男）★★:司祭サマとして治安維持のためってか<br>…戻ってくる気はねえんだな？
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_09030039")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★リアム★★:はっきり申し上げたはずです<br>「お断りします」とね
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09030040")


	--★★市民（男）★★:はっは！上等だ！
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_09030042")

	change_face(Actor002,"Smile")

	--★★リアム★★:ご理解いただけたようでなによりです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09030044")

	change_face(Actor002,"Normal")

	--★★リアム★★:それで…彼らについて<br>どこまで調べがついているのですか？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09030045")

	PlayAction(Actor004,"to  Std_Talk")

	--★★市民（中年男）②★★:今、アジトを探ってる<br>特定でき次第、作戦を決行するつもりだ
	Talk(Actor004,"NPCNAME_0252","speech","N","CO_101064_09030046")


	--★★リアム★★:向こうの人数は？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09030047")

	PlayAction(Actor005,"to  Std_Worry")

	--★★市民（中年男）★★:２０…いや、３０人ってところかな
	Talk(Actor005,"NPCNAME_0251","speech","N","CO_101064_09030048")


	--★★市民（男）★★:こっちはてめえらを入れて５人だ
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_09030049")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（いつの間にか勘定に入れられてる…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101064_09030050")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★リアム★★:ふっ…楽しい集会になりそうですね
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09030051")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★市民（男）★★:血が煮えたぎってきたんじゃねえか？<br>あの頃みてえによ
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_09030053")

	PlayAction(Actor004,"to  Std_Talk")

	--★★市民（中年男）②★★:決行日が決まったら連絡すっからよ<br>もう少し待っていてくれや
	Talk(Actor004,"NPCNAME_0252","speech","N","CO_101064_09030054")

-- ▼直接出力
local trustParam = set_communication_rankup("リアム_コミュランク", "リアム_親密度")
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
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(112041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401021","001","401021001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401027","001","401027001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
