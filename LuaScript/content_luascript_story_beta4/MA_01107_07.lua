-- このluaスクリプトは、MA_01107_07.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera003 = SetTemplate("Actor003",-70,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera004 = SetTemplate("Actor004",-35,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera005 = SetTemplate("Actor005",-105,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera007 = SetTemplate("Actor007",-55,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
DontChangeRandomCamera(true)
Hide(Actor006)
set_pos(Actor004,{0.5,0,-1.3})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to  Std_Talk")

	--★★マルディサント★★:アタシがサボってたぶんの補習…<br>ってワケじゃねえよなァ？
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01107_070002")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ギネヴィア★★:どっちかと言えば<br>ノワールとディナタンのための補講よ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01107_070003")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad01")
	change_face(Actor003,"Sad")

	--★★ディナタン★★:わ、私、サボってましたか…？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01107_070004")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
change_face(Actor003,"Normal")
-- ▲直接出力

	--★★ギネマウア★★:他の者よりも学園で学ぶ時間がまだ少ない<br>お二方に向けたものです
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_070005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:ローマ皇太子殿下に謁見を申し出るんだもの<br>知識不足で馬鹿にされるのもシャクでしょ？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01107_070006")

	PlayAction(Actor004,"to  Std_Worry")

	--★★マルディサント★★:じゃあアタシはいなくていいよなァ<br>アタシ謁見しねえもんよォ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01107_070008")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(Camera001)
Appear(Actor006)
keep_ik_lookat(Actor003,Actor006,"J_Head")
keep_ik_lookat(Actor004,Actor006,"J_Head")
keep_ik_lookat(Actor005,Actor006,"J_Head")
keep_ik_lookat(Actor007,Actor006,"J_Head")
Hide(Actor006)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:特別ゲストをお呼びしております
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01107_070009")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor006,Camera006,EntryDataDuelCommonFormation01_05,CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_105)
-- ▲直接出力
	PlayAction(Actor006,"to Greet_one")
-- ▼直接出力
keep_ik_lookat(Actor001,Actor006,"J_Head")
keep_ik_lookat(Actor002,Actor006,"J_Head")
change_face(Actor001,"Normal")
-- ▲直接出力

	--★★ランスロット★★:よろしく頼む
	Talk(Actor006,"CHRNAME_LANCELOT","speech","L","MA_01107_070011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to  Std_Joy")
turn_chara(Actor004,-40,0.3)
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★マルディサント★★:ウワ最強騎士じゃん！！マジかよ！！ヒュー！<br>最強騎士の最強補講ってことかぁヤッタネおい！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01107_070013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor005,"Normal","MA_01107_070015","MA_01107_070016","MA_01107_070017")
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
manager.CloseupUpExclusiveCamera(Actor005)
change_face(Actor004,"Normal")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:なにを教えてくれるんだ、ランスロット
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01107_070019")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★ランスロット★★:お前たちに知っておいて欲しいことだ
	Talk(Actor006,"CHRNAME_LANCELOT","speech","L","MA_01107_070020")

	change_face(Actor003,"Normal")

	--★★ディナタン★★:…ランス兄ちゃん
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01107_070021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor005)
change_face(Actor004,"Normal")
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor002,true)
keep_delay_ik_lookat(Actor005,Actor001,"J_Head",1)
-- ▲直接出力
	change_face(Actor005,"Laugh")

	--★★ノワール★★:色々とありがとう、ギネヴィア<br>…気を遣ってくれたみたいで
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01107_070023")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:なに言ってんのよぉ<br>お互い様でしょぉ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01107_070025")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:殿下は照れ隠しが下手ですね
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_070026")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor005)
change_face(Actor004,"Normal")
set_enable_auto_lookat(Actor003,true)
keep_delay_ik_lookat(Actor005,Actor003,"J_Head",1)
-- ▲直接出力
	change_face(Actor005,"Laugh")

	--★★ノワール★★:しっかり勉強しよう、ディナタン
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01107_070028")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★ディナタン★★:うん、兄さん
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01107_070029")

-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Talk")
turn_chara(Actor003,-25,0.3)
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディナタン★★:居眠りしちゃっても<br>私が後で教えてあげるからね？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01107_070031")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat_all(true)
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
change_face(Actor003,"Normal")
PlayActionDirect(Actor003,"to Std_Loop")
turn_chara(Actor003,-60,0.5)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Normal")

	--★★ランスロット★★:伝えたいことはひとつ<br>『GSの必要性』についてだ
	Talk(Actor006,"CHRNAME_LANCELOT","speech","L","MA_01107_070033")


	--★★ランスロット★★:なぜ学園が生徒たちをＧＳへと導くのか<br>皆がお前にもそれを求めるのは、どうしてか
	Talk(Actor006,"CHRNAME_LANCELOT","speech","L","MA_01107_070035")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Worry")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★マルディサント★★:あんだよアタシ授業でやったわ～<br>イチ抜け～
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01107_070037")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",1)
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Surp")
turn_chara(Actor003,-95,0.3)
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ディナタン★★:マァル、いい子にするっ
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01107_070038")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat_all(true)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor006,"J_Head",1)
change_face(Actor003,"Normal")
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力

	--★★ランスロット★★:キラーズには太古に活躍したとされる<br>伝説の武器の因子が一銘、刻まれている
	Talk(Actor006,"CHRNAME_LANCELOT","speech","L","MA_01107_070040")

-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor007,"J_Head",1)
PlayActionDirect(Actor004,"to  Std_Talk")
turn_chara(Actor004,25,0.5)
-- ▲直接出力

	--★★マルディサント★★:ってかなんでアタシらにそんな因子があるワケ？<br>そこんトコどうなんだよ、オニーサンのキラーズ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01107_070041")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat_all(false)
-- ▲直接出力
	play_head_motion(Actor007, "No", 0.3, 1.0, false)

	--★★ティルフィング★★:…明確にはお答えできませんが
	Talk(Actor007,"CHRNAME_TYRFING","speech","L","MA_01107_070042")


	--★★ティルフィング★★:バルバロイとの戦いを宿命づけられたゆえ<br>その対抗手段として宿されている…としか
	Talk(Actor007,"CHRNAME_TYRFING","speech","L","MA_01107_070043")

-- ▼直接出力
lookat_weight_reset(Actor001)
lookat_weight_reset(Actor002)
lookat_weight_reset(Actor006)
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_No")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★マルディサント★★:答えになってねえなあ<br>そういうとこだぞ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01107_070044")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat_all(true)
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor002,false)
set_enable_auto_lookat(Actor006,false)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
turn_chara(Actor004,-40,1)
-- ▲直接出力

	--★★ランスロット★★:使い手となるバイブスが相手のキラーズ因子を<br><ruby=ファクタライズ>因枢分解</ruby>することで銘が解明される──
	Talk(Actor006,"CHRNAME_LANCELOT","speech","L","MA_01107_070046")

	change_face(Actor002,"Normal")

	--★★ギネマウア★★:<ruby=ギネマウア>私</ruby>はロンゴミアントという銘が<br><ruby=バイブス>殿下</ruby>によって明かされ、キラーズとなりました
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_070048")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:…因枢分解
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01107_070050")

	change_face(Actor003,"Normal")

	--★★ディナタン★★:こうやってふだん生活しているぶんには<br>変化は感じないけど…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01107_070052")

-- ▼直接出力
set_enable_auto_lookat(Actor003,true)
keep_delay_ik_lookat(Actor004,Actor007,"J_Head",1)
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★マルディサント★★:<ruby=バト>戦闘状態に入</ruby>るときは<br>カラダが強くなった感があるよな
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01107_070053")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat_all(true)
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor002,false)
set_enable_auto_lookat(Actor006,false)
-- ▲直接出力
-- ▼直接出力
change_face(Actor004,"Normal")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:キラーズの素質をもつ人間の形態を<br>バイブスの力で武器の形態へと移す儀を果たし…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01107_070055")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ギネヴィア★★:そうして<ruby=ファクタライズされる>戦闘状態に入る</ruby>ことで<br>キラーズとバイブス互いの力が<ruby=かけざん>乗算</ruby>式に向上する
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01107_070057")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat_all(false)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Surp")
	change_face(Actor005,"Surprise")

	--★★ノワール★★:乗算…！？<br>つまり、ふたりの力が高まれば──
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01107_070059")


	--★★ランスロット★★:武器としての力も、使い手としての力も<br>人としての限界を超えて高め合える
	Talk(Actor006,"CHRNAME_LANCELOT","speech","L","MA_01107_070060")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ギネヴィア★★:乗算…っていうのは、ざっと見積もって<br>そんぐらいかも？って程度の目安だけどね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01107_070062")


	--★★ランスロット★★:存在が分解され、戦うべき姿へと最適化される<br>その強さの源は互いの記憶──すなわち絆だ
	Talk(Actor006,"CHRNAME_LANCELOT","speech","L","MA_01107_070063")

	change_face(Actor003,"Surprise")

	--★★ディナタン★★:ふたりの絆が深まるほど<br>つよく、なれる…？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01107_070065")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat_all(true)
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor002,false)
set_enable_auto_lookat(Actor006,false)
-- ▲直接出力

	--★★ランスロット★★:想いを共有し、思い出に共感し<br>互いの記憶を共鳴させていくことで──
	Talk(Actor006,"CHRNAME_LANCELOT","speech","L","MA_01107_070067")


	--★★ランスロット★★:その人物の存在の深淵が明らかになっていく<br><ruby=いにしえ>古</ruby>に刻まれた<ruby=キラーズ>伝説の武器</ruby>の力が<ruby=とりもどされて>思い出されて</ruby>いく
	Talk(Actor006,"CHRNAME_LANCELOT","speech","L","MA_01107_070068")


	--★★ギネヴィア★★:それを<br>つがいの絆で鍛えていく
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01107_070070")


	--★★ギネマウア★★:それは人ならざる力ゆえ<br>代えのきかぬ『一命一銘』の契約…
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_070072")


	--★★ランスロット★★:………だから、ノワール
	Talk(Actor006,"CHRNAME_LANCELOT","speech","L","MA_01107_070074")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor006,"Laugh")

	--★★ランスロット★★:急がなくていい
	Talk(Actor006,"CHRNAME_LANCELOT","speech","L","MA_01107_070075")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:お前が結ぶべき絆を<br>ゆっくりと見つければいい
	Talk(Actor006,"CHRNAME_LANCELOT","speech","L","MA_01107_070077")

-- ▼直接出力
change_face(Actor005,"Normal")
-- ▲直接出力

	--★★ランスロット★★:世界の行く末がどうであれ<br>俺はいつまでも──
	Talk(Actor006,"CHRNAME_LANCELOT","speech","L","MA_01107_070078")

-- ▼直接出力
setup_small_camera_start(Camera005)
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★ランスロット★★:お前のことを、待っている
	Talk(Actor006,"CHRNAME_LANCELOT","speech","L","MA_01107_070079")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor001)
Hide(Actor002)
Hide(Actor003)
Hide(Actor004)
Hide(Actor006)
Camera005=setup_small_camera_resetting(Actor005,CharaPos002,CameraPos002)
Camera007=setup_small_camera_resetting(Actor007,CharaPos006,CameraPos006)
set_enable_auto_lookat_all(false)
lookat_weight_reset(Actor005)
lookat_weight_reset(Actor007)
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Talk")

	--★★ティルフィング★★:マスター…アナタもまた<br>ご自身のつがいを見つける必要があります
	Talk(Actor007,"CHRNAME_TYRFING","speech","L","MA_01107_070081")


	--★★ティルフィング★★:あくまで導き手である私とは異なる<br>この歴史における絆の結び目を
	Talk(Actor007,"CHRNAME_TYRFING","speech","L","MA_01107_070082")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:俺の、つがい
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01107_070083")


	--★★ティルフィング★★:アナタは継承者<br>無尽の武器庫と無限の武具を継ぐ者
	Talk(Actor007,"CHRNAME_TYRFING","speech","L","MA_01107_070084")


	--★★ティルフィング★★:それらのあいだに紡ぐ絆もまたアナタの力となる<br>この歴史に生きる者とは一線を画した膨大な力が
	Talk(Actor007,"CHRNAME_TYRFING","speech","L","MA_01107_070085")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:『継承者』──…
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01107_070086")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Sad")

	--★★ノワール★★:そんな力を与えられているのは何故だ？<br>俺になにをさせようとしているんだ？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01107_070087")

	PlayAction(Actor007,"to  Std_No")
	change_face(Actor007,"Sad")

	--★★ティルフィング★★:アナタは…未来を拓く切り札<br>なすべきことはいずれ明かされます
	Talk(Actor007,"CHRNAME_TYRFING","speech","L","MA_01107_070088")

	PlayAction(Actor005,"to  Std_Sad02")

	--★★ノワール★★:…キミの口からは<br>やっぱり聞けないんだ
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01107_070089")

	change_face(Actor007,"Normal")

	--★★ティルフィング★★:ですが忘れないでください<br>その力はアナタの願いを叶える手段でもある
	Talk(Actor007,"CHRNAME_TYRFING","speech","L","MA_01107_070090")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)

	--★★ティルフィング★★:バルバロイを討ち果たし<br>真実を掴むための
	Talk(Actor007,"CHRNAME_TYRFING","speech","L","MA_01107_070091")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
